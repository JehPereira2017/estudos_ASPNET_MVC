using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroCNPJ.Data;
using CadastroCNPJ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CadastroCNPJ.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private readonly FitcardTesteContext _context;
        public EstabelecimentoController(FitcardTesteContext fitcardTesteContext)
        {
            _context = fitcardTesteContext;
        }
        public string ClearString(string varLimpar)
        {
            return varLimpar.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
        }
        public bool ValidarTelefone(string telefone, int categoria)
        {
            if (telefone == "" && categoria == 1) return false;
            return true;
        }
        public bool ValidarCnpj(string cnpj)
        {
            if (cnpj.Length == 18)
            {
                int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma;
                int resto;
                string digito;
                string tempCnpj;
                cnpj = cnpj.Trim();
                cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
                if (cnpj.Length != 14) { return false; }
                tempCnpj = cnpj.Substring(0, 12);
                soma = 0;
                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCnpj = tempCnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }
            return true;
        }
        public IActionResult Index()
        {
            List<Estabelecimento> lstEstab = new List<Estabelecimento>();
            lstEstab = _context.Estabelecimento.Include(s => s.StatusEstabelecimentoNavigation).ToList();
            return View(lstEstab);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> estados = _context.Estado.AsNoTracking().OrderBy(n =>
            n.Descricao).Select(n => new SelectListItem { Value = n.IdEstado.ToString(), Text = n.Descricao }).ToList();
            var estadoInit = new SelectListItem()
            {
                Value = null,
                Text = "--- selecione um estado ---"
            };
            estados.Insert(0, estadoInit);
            var mun = new MunicipioRepository(_context);
            var cat = new CategoriaRepository(_context);
            var status = new StatusRepository(_context);
            var estab = new Estabelecimento()
            {
                Estados = estados,
                Cidades = mun.GetMunicipios(),
                Categorias = cat.GetCategorias(),
                Status = status.GetStatus()
            };
            return View(estab);
        }
        [HttpGet]
        public ActionResult GetMunicipios(string idEstado)
        {
            if (!string.IsNullOrWhiteSpace(idEstado) && idEstado.Length == 2)
            {
                var repo = new MunicipioRepository(_context);
                IEnumerable<SelectListItem> municipios = repo.GetMunicipios(idEstado);
                var json = Json(municipios);
                return json;
            }
            return null;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] Estabelecimento estabelecimento)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    estabelecimento.Cnpj = ClearString(estabelecimento.Cnpj);
                    estabelecimento.Agencia = ClearString(estabelecimento.Agencia);
                    estabelecimento.Conta = ClearString(estabelecimento.Conta);
                    _context.Estabelecimento.Add(estabelecimento);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (DbUpdateException ex)
            {
                //Logar o erro (descomente a variável ex e escreva um log
                ModelState.AddModelError("", "Não foi possível salvar. " +
                    "Tente novamente, e se o problema persistir " +
                    "chame o suporte.");
            }
            return View(estabelecimento);
        }
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estab = _context.Estabelecimento.Where(e => e.IdEstabelecimento == id).First();
            if (estab == null)
            {
                return NotFound();
            }
            return View(estab);
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var atualizarEstabelecimento = _context.Estabelecimento.Where(e => e.IdEstabelecimento == id).First();
            if (await TryUpdateModelAsync<Estabelecimento>(atualizarEstabelecimento))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateException /* ex */)
                {
                    //Logar o erro (descomente a variável ex e escreva um log
                    ModelState.AddModelError("", "Não foi possível salvar. " +
                        "Tente novamente, e se o problema persistir " +
                        "chame o suporte.");
                }
            }
            return View(atualizarEstabelecimento);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }
            var estabelecimento = await _context.Estabelecimento
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.IdEstabelecimento == id);

            if (estabelecimento == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "A exclusão falhou. Tente novamente e se o problema persistir " +
                    "contate o suporte.";
            }
            return View(estabelecimento);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var estabelecimento = await _context.Estabelecimento
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.IdEstabelecimento == id);
            if (estabelecimento == null)
            {
                return RedirectToAction("Index");
            }
            try
            {
                _context.Estabelecimento.Remove(estabelecimento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (DbUpdateException /* ex */)
            {
                //Logar o erro
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estab = await _context.Estabelecimento
                .FirstOrDefaultAsync(m => m.IdEstabelecimento == id);
            if (estab == null)
            {
                return NotFound();
            }

            return View(estab);
        }
    }
}
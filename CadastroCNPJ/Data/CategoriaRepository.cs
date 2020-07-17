using CadastroCNPJ.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCNPJ.Data
{
    public class CategoriaRepository
    {
        private readonly FitcardTesteContext _context;
        public CategoriaRepository(FitcardTesteContext fitcardTesteContext)
        {
            _context = fitcardTesteContext;
        }
        public IEnumerable<SelectListItem> GetCategorias()
        {
            List<SelectListItem> categorias = _context.Categoria.AsNoTracking().OrderBy(n =>
            n.DescricaoCategoria).Select(n =>
            new SelectListItem { Value = n.IdCategoria.ToString(), Text = n.DescricaoCategoria }).ToList();

            return categorias;
        }
    }
}

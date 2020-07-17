using CadastroCNPJ.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCNPJ.Data
{
    public class MunicipioRepository
    {
        private readonly FitcardTesteContext _context;
        public MunicipioRepository(FitcardTesteContext fitcardTesteContext)
        {
            _context = fitcardTesteContext;
        }
        public IEnumerable<SelectListItem> GetMunicipios()
        {
            List<SelectListItem> municipios = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Value = null,
                    Text = " "
                }
            };
            return municipios;
        }

        public IEnumerable<SelectListItem> GetMunicipios(string idEstado)
        {
            if (!String.IsNullOrWhiteSpace(idEstado))
            {
                using (var context = _context)
                {
                    IEnumerable<SelectListItem> municipios = context.Municipio.AsNoTracking()
                        .OrderBy(n => n.Descricao)
                        .Where(n => n.IdEstado.ToString() == idEstado)
                        .Select(n =>
                           new SelectListItem
                           {
                               Value = n.IdMunicipio.ToString(),
                               Text = n.Descricao
                           }).ToList();
                    return new SelectList(municipios, "Value", "Text");
                }
            }
            return null;
        }
    }
}

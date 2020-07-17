using CadastroCNPJ.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCNPJ.Data
{
    public class StatusRepository
    {
        private readonly FitcardTesteContext _context;
        public StatusRepository(FitcardTesteContext fitcardTesteContext)
        {
            _context = fitcardTesteContext;
        }
        public IEnumerable<SelectListItem> GetStatus()
        {
            List<SelectListItem> status = _context.Status.AsNoTracking().OrderBy(n =>
            n.DescricaoStatus).Select(n =>
            new SelectListItem { Value = n.IdStatus.ToString(), Text = n.DescricaoStatus }).ToList();

            return status;
        }
    }
}

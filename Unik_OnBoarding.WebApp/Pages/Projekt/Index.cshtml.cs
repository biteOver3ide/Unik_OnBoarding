using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.WebApp.Pages.Projekt
{
    public class IndexModel : PageModel
    {
        private readonly Unik_OnBoarding.Persistance.DbContext.AppDbContext _context;

        public IndexModel(Unik_OnBoarding.Persistance.DbContext.AppDbContext context)
        {
            _context = context;
        }

        public IList<ProjektEntity> ProjektEntity { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Projektes != null)
            {
                ProjektEntity = await _context.Projektes
                .Include(p => p.Kunde).ToListAsync();
            }
        }
    }
}

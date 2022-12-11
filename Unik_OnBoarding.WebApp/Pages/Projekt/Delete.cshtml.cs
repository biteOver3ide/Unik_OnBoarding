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
    public class DeleteModel : PageModel
    {
        private readonly Unik_OnBoarding.Persistance.DbContext.AppDbContext _context;

        public DeleteModel(Unik_OnBoarding.Persistance.DbContext.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ProjektEntity ProjektEntity { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Projektes == null)
            {
                return NotFound();
            }

            var projektentity = await _context.Projektes.FirstOrDefaultAsync(m => m.ProjektId == id);

            if (projektentity == null)
            {
                return NotFound();
            }
            else 
            {
                ProjektEntity = projektentity;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Projektes == null)
            {
                return NotFound();
            }
            var projektentity = await _context.Projektes.FindAsync(id);

            if (projektentity != null)
            {
                ProjektEntity = projektentity;
                _context.Projektes.Remove(ProjektEntity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

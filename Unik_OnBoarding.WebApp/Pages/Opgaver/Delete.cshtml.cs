using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DatabaseContext;

namespace Unik_OnBoarding.WebApp.Pages.Opgaver
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public OpgaverEntity OpgaverEntity { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Opgaver == null)
            {
                return NotFound();
            }

            var opgaverentity = await _context.Opgaver.FirstOrDefaultAsync(m => m.OpgaveId == id);

            if (opgaverentity == null)
            {
                return NotFound();
            }
            else 
            {
                OpgaverEntity = opgaverentity;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null || _context.Opgaver == null)
            {
                return NotFound();
            }
            var opgaverentity = await _context.Opgaver.FindAsync(id);

            if (opgaverentity != null)
            {
                OpgaverEntity = opgaverentity;
                _context.Opgaver.Remove(OpgaverEntity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

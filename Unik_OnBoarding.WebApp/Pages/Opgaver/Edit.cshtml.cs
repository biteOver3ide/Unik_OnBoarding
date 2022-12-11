using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.WebApp.Pages.Opgaver
{
    public class EditModel : PageModel
    {
        private readonly Unik_OnBoarding.Persistance.DbContext.AppDbContext _context;

        public EditModel(Unik_OnBoarding.Persistance.DbContext.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OpgaverEntity OpgaverEntity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Opgaver == null)
            {
                return NotFound();
            }

            var opgaverentity =  await _context.Opgaver.FirstOrDefaultAsync(m => m.OpgaveId == id);
            if (opgaverentity == null)
            {
                return NotFound();
            }
            OpgaverEntity = opgaverentity;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OpgaverEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpgaverEntityExists(OpgaverEntity.OpgaveId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OpgaverEntityExists(Guid id)
        {
          return _context.Opgaver.Any(e => e.OpgaveId == id);
        }
    }
}

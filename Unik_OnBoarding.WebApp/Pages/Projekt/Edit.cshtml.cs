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

namespace Unik_OnBoarding.WebApp.Pages.Projekt
{
    public class EditModel : PageModel
    {
        private readonly Unik_OnBoarding.Persistance.DbContext.AppDbContext _context;

        public EditModel(Unik_OnBoarding.Persistance.DbContext.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProjektEntity ProjektEntity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.Projektes == null)
            {
                return NotFound();
            }

            var projektentity =  await _context.Projektes.FirstOrDefaultAsync(m => m.ProjektId == id);
            if (projektentity == null)
            {
                return NotFound();
            }
            ProjektEntity = projektentity;
           ViewData["KundeId"] = new SelectList(_context.Kunder, "Kid", "Adresse");
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

            _context.Attach(ProjektEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjektEntityExists(ProjektEntity.ProjektId))
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

        private bool ProjektEntityExists(Guid id)
        {
          return _context.Projektes.Any(e => e.ProjektId == id);
        }
    }
}

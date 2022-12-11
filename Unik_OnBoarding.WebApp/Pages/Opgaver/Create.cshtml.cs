using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.WebApp.Pages.Opgaver
{
    public class CreateModel : PageModel
    {
        private readonly Unik_OnBoarding.Persistance.DbContext.AppDbContext _context;

        public CreateModel(Unik_OnBoarding.Persistance.DbContext.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OpgaverEntity OpgaverEntity { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Opgaver.Add(OpgaverEntity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

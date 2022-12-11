using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Kunde
{
    public class DeleteModel : PageModel
    {
        private readonly IKundeService _kundeService;

        public DeleteModel(IKundeService kundeService)
        {
            _kundeService = kundeService;
            
        }

        [BindProperty] public QueryKundeResultDto Drt { get; set; }

        public async Task<IActionResult> OnGet(Guid id)
        {
            if (id == null) return NotFound();

            try
            {
                Drt = await _kundeService.Get(id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return Page();
            }

            return Page();
        }


        public async Task<IActionResult> OnPost(Guid id)
        {
            if (!ModelState.IsValid)
                return Page();
            try
            {
                await _kundeService.Delete(id);
                return RedirectToPage("/Kunde/Index");
            }
            catch (DbUpdateConcurrencyException e)
            {
                ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
                return Page();
            }
        }
    }
}

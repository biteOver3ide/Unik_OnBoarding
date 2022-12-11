using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Medarbejder
{
    public class DeleteModel : PageModel
    {
        private readonly IMedarbejderService _medarbejderService;

        public DeleteModel(IMedarbejderService medarbejderService)
        {
            _medarbejderService = medarbejderService;
        }

        [BindProperty] public QueryMedarbejderResultDto Drt { get; set; }

        public async Task<IActionResult> OnGet(Guid id)
        {
            if (id == null) return NotFound();

            try
            {
                Drt = await _medarbejderService.Get(id);
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
                await _medarbejderService.Delete(id);
                return RedirectToPage("/Medarbejder/Index");
            }
            catch (DbUpdateConcurrencyException e)
            {
                ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
                return Page();
            }
        }
    }
}

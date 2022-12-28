using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Medarbejder
{
    public class EditModel : PageModel
    {
        private readonly IMedarbejderService _medarbejderService;

        public EditModel(IMedarbejderService medarbejderService)
        {
            _medarbejderService = medarbejderService;
        }

        [BindProperty] public QueryMedarbejderResultDto Urt { get; set; }

        public async Task<IActionResult> OnGet(Guid Id)
        {
	        try
            {
                Urt = await _medarbejderService.Get(Id);
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return Page();
            }
            
            return Page();
        }


        public async Task<IActionResult> OnPost()
        {

            if (!ModelState.IsValid)
                return Page( );

            try
            {
                await _medarbejderService.Edit(Urt);
                return RedirectToPage("/Medarbejder/Index");
            }
            catch (DbUpdateConcurrencyException e)
            {
                ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
                return Page( );
            }
        }
    }
}

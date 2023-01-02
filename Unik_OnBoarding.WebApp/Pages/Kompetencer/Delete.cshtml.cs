using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Kompetencer;

public class DeleteModel : PageModel
{
    private readonly IKompetenceService _kompetenceService;

    public DeleteModel(IKompetenceService kompetenceService)
    {
        _kompetenceService = kompetenceService;
    }

    [BindProperty] public QueryKompetenceResultDto Drt { get; set; }

    public async Task<IActionResult> OnGet(Guid id)
    {
	    try
        {
            Drt = await _kompetenceService.Get(id);
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
            await _kompetenceService.Delete(id);
            return RedirectToPage("/Kompetencer/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
            return Page();
        }
    }
}
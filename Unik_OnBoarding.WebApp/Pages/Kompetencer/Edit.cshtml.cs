using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Kompetencer;

public class EditModel : PageModel
{
    private readonly IKompetenceService _kompetenceService;

    public EditModel(IKompetenceService kompetenceService)
    {
        _kompetenceService = kompetenceService;
    }

    [BindProperty] public QueryKompetenceResultDto Urt { get; set; }

    public async Task<IActionResult> OnGet(Guid Id)
    {
        if (Id == null) return NotFound();

        try
        {
            Urt = await _kompetenceService.Get(Id);
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
            return Page();

        try
        {
            await _kompetenceService.Edit(Urt);
            return RedirectToPage("/Kompetencer/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
            return Page();
        }
    }
}
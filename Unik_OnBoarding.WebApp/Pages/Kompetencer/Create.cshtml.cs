using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Kompetencer;

public class CreateModel : PageModel
{
    private readonly IKompetenceService _kompetenceService;

    public CreateModel(IKompetenceService kompetenceService)
    {
        _kompetenceService = kompetenceService;
    }

    [BindProperty] public CreateKompetenceDto Crt { get; set; }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid) return Page();

        try
        {
            await _kompetenceService.Create(Crt);
            return new RedirectToPageResult("/Kompetener/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, "Concurrency conflict");
            return Page();
        }
    }
}
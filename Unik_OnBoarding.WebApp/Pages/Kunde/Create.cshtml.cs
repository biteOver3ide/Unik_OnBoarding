using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Kunde;

public class CreateModel : PageModel
{
    private readonly IKundeService _kundeService;

    public CreateModel(IKundeService kundeService)
    {
        _kundeService = kundeService;
    }

    [BindProperty] 
    public CreateKundeRequestDto Crt { get; set; }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid) return Page();

        try
        {
            await _kundeService.Create(Crt);
            return new RedirectToPageResult("/Kunde/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, $"Concurrency conflict: {e}");
            return Page();
        }
    }
}
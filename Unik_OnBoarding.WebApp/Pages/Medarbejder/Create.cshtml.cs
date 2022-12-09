using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Medarbejder;

public class CreateModel : PageModel
{
    private readonly IMedarbejderService _medarbejderService;

    public CreateModel(IMedarbejderService medarbejderService)
    {
        _medarbejderService = medarbejderService;
    }

    [BindProperty] public MedarbejderCreateRequestDto Crt { get; set; }

    public async Task<IActionResult> OnPost()
    {

        if (!ModelState.IsValid) return Page();

        try
        {
            await _medarbejderService.Create(Crt);
            return new RedirectToPageResult("/Medarbejder/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, "Concurrency conflict");
            return Page();
        }
    }
}
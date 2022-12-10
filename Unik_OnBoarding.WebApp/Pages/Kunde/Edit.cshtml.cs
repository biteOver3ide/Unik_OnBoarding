using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Kunde;

public class EditModel : PageModel
{
    private readonly IKundeService _kundeService;

    public EditModel(IKundeService kundeService)
    {
        _kundeService = kundeService;
    }

    [BindProperty] public KundeQueryResultDto Urt { get; set; }

    public async Task<IActionResult> OnGet(Guid Id)
    {
        if (Id == null) return NotFound();

        try
        {
            Urt = await _kundeService.Get(Id);
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
            await _kundeService.Edit(Urt);
            return RedirectToPage("/Kunde/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
            return Page();
        }
    }
}
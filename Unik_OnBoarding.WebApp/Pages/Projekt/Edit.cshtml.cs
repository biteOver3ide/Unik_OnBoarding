using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Projekt;

public class EditModel : PageModel
{
    private readonly IProjektService _projektService;

    public EditModel(IProjektService projektService)
    {
        _projektService = projektService;
    }

    [BindProperty] public QueryProjektResultDto Urt { get; set; }

    public async Task<IActionResult> OnGet(Guid Id)
    {
        if (Id == null) return NotFound();

        try
        {
            Urt = await _projektService.Get(Id);
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
            await _projektService.Edit(Urt);
            return RedirectToPage("/Projekt/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
            return Page();
        }
    }
}
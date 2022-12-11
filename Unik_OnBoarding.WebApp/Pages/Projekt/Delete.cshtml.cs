using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Projekt;

public class DeleteModel : PageModel
{
    private readonly IProjektService _projektService;


    public DeleteModel(IProjektService projektService)
    {
        _projektService = projektService;
    }

    [BindProperty] public QueryProjektResultDto Drt { get; set; }

    public async Task<IActionResult> OnGet(Guid id)
    {
        if (id == null) return NotFound();

        try
        {
            Drt = await _projektService.Get(id);
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
            await _projektService.Delete(id);
            return RedirectToPage("/Projekt/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
            return Page();
        }
    }
}
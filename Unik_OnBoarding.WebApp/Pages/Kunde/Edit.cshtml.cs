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

    [BindProperty] public QueryKundeResultDto Urt { get; set; }

    public async Task<IActionResult> OnGet(Guid id)
    {
	    try
        {
			//Search For Kunde To Update
			Urt = await _kundeService.Get(id);
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
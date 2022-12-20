using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Opgaver;

public class EditModel : PageModel
{
	private readonly IOpgaverService _opgaverService;

	public EditModel(IOpgaverService opgaverService)
	{
		_opgaverService = opgaverService;
	}

	[BindProperty] public QueryOpgaverResultDto Urt { get; set; }

	public async Task<IActionResult> OnGet(Guid Id)
	{
		if (Id == null) return NotFound();

		try
		{
			Urt = await _opgaverService.Get(Id);
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
			await _opgaverService.Edit(Urt);
			return RedirectToPage("/Opgaver/Index");
		}
		catch (DbUpdateConcurrencyException e)
		{
			ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
			return Page();
		}
	}
}
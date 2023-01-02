using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Opgaver;

public class DeleteModel : PageModel
{
	private readonly IOpgaverService _opgaverService;

	public DeleteModel(IOpgaverService opgaverService)
	{
		_opgaverService = opgaverService;
	}

	[BindProperty] public QueryOpgaverResultDto Drt { get; set; }

	public async Task<IActionResult> OnGet(Guid id)
	{
		try
		{
			Drt = await _opgaverService.Get(id);
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
			await _opgaverService.Delete(id);
			return RedirectToPage("/Opgaver/Index");
		}
		catch (DbUpdateConcurrencyException e)
		{
			ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
			return Page();
		}
	}
}
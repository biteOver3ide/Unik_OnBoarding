using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Opgaver;

public class CreateModel : PageModel
{
	private readonly IOpgaverService _opgaverService;

	public CreateModel(IOpgaverService opgaverService)
	{
		_opgaverService = opgaverService;
	}

	[BindProperty] public CreateOpgaverDto Crt { get; set; }


	public async Task<IActionResult> OnPost()
	{
		if (!ModelState.IsValid) return Page();

		try
		{
			await _opgaverService.Create(Crt);
			return new RedirectToPageResult("/Opgaver/Index");
		}
		catch (Exception e)
		{
			ModelState.AddModelError(string.Empty, "Concurrency conflict");
			return Page();
		}
	}
}
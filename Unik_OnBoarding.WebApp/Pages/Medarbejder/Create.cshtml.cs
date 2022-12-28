using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

	[BindProperty] public CreateMedarbejderRequestDto Crt { get; set; }

	public async Task<IActionResult> OnPost()
	{
		

		//var dto = new CreateMedarbejderRequestDto
		//{
		//	Fornavn = Crt.Fornavn,
		//	Efternavn = Crt.Efternavn,
		//	Email = Crt.Email,
		//	Telefon = Crt.Telefon,
		//	Job = Crt.Job,
		//	UserId = User.Identity?.Name ?? string.Empty
		//};
		if (!ModelState.IsValid) return Page();
		try
		{
			await _medarbejderService.Create(Crt);
			return new RedirectToPageResult("/Medarbejder/Index");
		}
		catch (Exception e)
		{
			ModelState.AddModelError(string.Empty, "Concurrency conflict");
			return Page();
		}
	}
}
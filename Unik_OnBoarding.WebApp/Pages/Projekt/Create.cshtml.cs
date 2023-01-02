using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Projekt;

[BindProperties]
public class CreateModel : PageModel
{
    private readonly IProjektService _projektService;
    private readonly IKundeService _kundeService;

    public CreateModel(IProjektService projektService, IKundeService kundeService)
    {
	    _projektService = projektService;
	    _kundeService = kundeService;
    }

    public CreateProjektRequestDto Crt { get; set; }
    public IEnumerable<QueryKundeResultDto> KundeList { get; set; }

    public async Task OnGet()
    {
	    KundeList = await _kundeService.GetAll();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid) return Page();

        try
        {
            await _projektService.Create(Crt);
            return new RedirectToPageResult("/Projekt/Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, "Concurrency conflict");
            return Page();
        }
    }
}
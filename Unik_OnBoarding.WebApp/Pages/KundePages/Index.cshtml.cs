using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.KundePages;

public class IndexModel : PageModel
{
    private readonly IKundeService _kundeService;


    public IndexModel(IKundeService kundeService)
    {
        _kundeService = kundeService;
    }

    [BindProperty] public IEnumerable<KundeQueryResultDto> IndexViewModel { get; set; }

    public async Task OnGet()
    {
        IndexViewModel = await _kundeService.GetAll();
    }
}
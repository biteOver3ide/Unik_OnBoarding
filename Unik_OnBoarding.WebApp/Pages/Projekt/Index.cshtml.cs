using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Projekt;

public class IndexModel : PageModel
{
    private readonly IProjektService _projektService;
    private readonly IKundeService _kundeService;

    public IndexModel(IProjektService projektService, IKundeService kundeService)
    {
        _projektService = projektService;
        _kundeService = kundeService;
    }

    [BindProperty] public IEnumerable<QueryProjektResultDto> IndexViewModel { get; set; }
    [BindProperty] public IEnumerable<QueryKundeResultDto> KundeViewModel { get; set; }

    public async Task OnGet()
    {
        IndexViewModel = await _projektService.GetAll();
        KundeViewModel = await _kundeService.GetAll();
    }
}
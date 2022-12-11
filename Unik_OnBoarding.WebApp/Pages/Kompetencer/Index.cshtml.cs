using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Kompetencer;

public class IndexModel : PageModel
{
    private readonly IKompetenceService _kompetenceService;

    public IndexModel(IKompetenceService kompetenceService)
    {
        _kompetenceService = kompetenceService;
    }

    [BindProperty] public IEnumerable<QueryKompetenceResultDto> KompetenceDto { get; set; }

    public async Task OnGet()
    {
        KompetenceDto = await _kompetenceService.GetAll();
    }
}
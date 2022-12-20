using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Opgaver;

public class IndexModel : PageModel
{
	private readonly IOpgaverService _opgaverService;

	public IndexModel(IOpgaverService opgaverService)
	{
		_opgaverService = opgaverService;
	}

	[BindProperty] public IEnumerable<QueryOpgaverResultDto> IndexViewModel { get; set; }

	public async Task OnGet()
	{
		IndexViewModel = await _opgaverService.GetAll();
	}
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.KundePages
{
    public class DetailsModel : PageModel
    {
        private readonly IKundeService _kundeService;


        public DetailsModel(IKundeService kundeService)
        {
            _kundeService = kundeService;
        }

        [BindProperty] public KundeQueryResultDto IndexViewModel { get; set; }

        public async Task OnGet(Guid id)
        {
            IndexViewModel = await _kundeService.Get(id);
        }
    }
}

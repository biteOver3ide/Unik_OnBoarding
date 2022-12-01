using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract;

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

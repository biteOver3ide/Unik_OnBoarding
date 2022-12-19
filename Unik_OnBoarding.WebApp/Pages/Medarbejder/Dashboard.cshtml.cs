using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Medarbejder
{
    [BindProperties]
    public class DashboardModel : PageModel
    {
        private readonly IProjektService _projektService;
        private readonly IOpgaverService _opgaverService;

        public DashboardModel(IProjektService projektService, IOpgaverService opgaverService)
        {
            _projektService = projektService;
            _opgaverService = opgaverService;
        }

        public IEnumerable<QueryProjektResultDto> ProjektList { get; set; }
        public IEnumerable<QueryOpgaverResultDto> OpgaverList { get; set; }

        public async Task OnGet()
        {
            ProjektList = await _projektService.GetAll();
            OpgaverList = await _opgaverService.GetAll();
        }

        //public async Task<IActionResult> OnPost()
        //{
        //    await
        //}
    }
}

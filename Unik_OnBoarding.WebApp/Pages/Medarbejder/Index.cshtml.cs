using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Medarbejder
{
    
    public class IndexModel : PageModel
    {
        private readonly IMedarbejderService _medarbejderService;

        public IndexModel(IMedarbejderService medarbejderService)
        {
            _medarbejderService = medarbejderService;
        }

        [BindProperty] public IEnumerable<QueryMedarbejderResultDto> IndexViewModel { get; set; }
       

        public async Task<IActionResult> OnGet(string? userId)
        {
            IndexViewModel = await _medarbejderService.GetAll();
            return Page();
        }
    }
}

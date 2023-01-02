using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Medarbejder
{
	[BindProperties]
    public class BookingModel : PageModel
    {
	    private readonly IBookingService _bookingService;
	    
	    private readonly IMedarbejderService _medarbejderService;
	    private readonly IOpgaverService _opgaverService;
	    private readonly IProjektService _projektService;


	    public BookingModel(IBookingService bookingService,
		    IProjektService projektService, IMedarbejderService medarbejderService, IOpgaverService opgaverService)
	    {
		    _bookingService = bookingService;
		   
		    _projektService = projektService;
		    _medarbejderService = medarbejderService;
		    _opgaverService = opgaverService;
	    }

	    public CreateBookingDto Booking { get; set; }
	    public IEnumerable<QueryBookingResultDto> BookingList { get; set; }
	    public IEnumerable<QueryProjektResultDto> ProjektList { get; set; }
	    public IEnumerable<QueryMedarbejderResultDto> MedarbejderList { get; set; }
	    public IEnumerable<QueryOpgaverResultDto> OpgaverList { get; set; }

	    public async Task OnGet()
	    {
		   
		    ProjektList = await _projektService.GetAll();
		    MedarbejderList = await _medarbejderService.GetAll();
		    OpgaverList = await _opgaverService.GetAll();
		    BookingList = await _bookingService.GetAll();
	    }


	    public async Task<IActionResult> OnPost()
	    {
		    if (!ModelState.IsValid) return Page();

		    try
		    {
			    await _bookingService.Create(Booking);
			    return RedirectToPage("/Medarbejder/Booking");
		    }
		    catch (Exception e)
		    {
			    ModelState.AddModelError(string.Empty, $"Concurrency conflict: {e}");
			    return Page();
		    }
	    }
	}
}

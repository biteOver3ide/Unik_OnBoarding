using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Admin
{
	[BindProperties]
	public class BookingDashboardModel : PageModel

    {
	    private readonly IBookingService _bookingService;
	    private readonly IKundeService _kundeService;
	    private readonly IMedarbejderService _medarbejderService;
	    private readonly IOpgaverService _opgaverService;
	    private readonly IProjektService _projektService;


	    public BookingDashboardModel(IBookingService bookingService, IKundeService kundeService,
		    IProjektService projektService, IMedarbejderService medarbejderService, IOpgaverService opgaverService)
	    {
		    _bookingService = bookingService;
		    _kundeService = kundeService;
		    _projektService = projektService;
		    _medarbejderService = medarbejderService;
		    _opgaverService = opgaverService;
	    }

	    public CreateBookingDto Booking { get; set; }
	    public IEnumerable<QueryBookingResultDto> BookingList { get; set; }
	    public IEnumerable<QueryKundeResultDto> KundeList { get; set; }
	    public IEnumerable<QueryProjektResultDto> ProjektList { get; set; }
	    public IEnumerable<QueryMedarbejderResultDto> MedarbejderList { get; set; }
	    public IEnumerable<QueryOpgaverResultDto> OpgaverList { get; set; }

	    public async Task OnGet()
	    {
		    KundeList = await _kundeService.GetAll();
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
			    return new RedirectToPageResult("/Admin/BookingDashboard");
			}
		    catch (Exception e)
		    {
			    ModelState.AddModelError(string.Empty, "Concurrency conflict");
			    return Page();
			}
	    }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Admin
{
    public class BookingIndexModel : PageModel
    {
	    private readonly IBookingService _bookingService;

	    public BookingIndexModel(IBookingService bookingService)
	    {
		    _bookingService = bookingService;
	    }

		[BindProperty] public IEnumerable<QueryBookingResultDto> IndexViewModel { get; set; }

		public async Task OnGet()
		{
			IndexViewModel = await _bookingService.GetAll();
		}
    }
}

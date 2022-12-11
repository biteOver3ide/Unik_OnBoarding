using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Admin.Bookings;

public class CreateModel : PageModel
{
    private readonly IBookingService _bookingService;
    private readonly IKundeService _kundeService;


    public CreateModel(IBookingService bookingService, IKundeService kundeService)
    {
        _bookingService = bookingService;
        _kundeService = kundeService;
    }

    [BindProperty] public CreateBookingDto CreateBooking { get; set; }
    [BindProperty] public IEnumerable<QueryKundeResultDto> IndexKunde { get; set; }

    public async Task<IActionResult> OnGet()
    {
        try
        {
            IndexKunde = await _kundeService.GetAll();
        }
        catch (Exception e)
        {
            ModelState.AddModelError(string.Empty, e.Message);
            return Page();
        }

        return Page();
    }


    public async Task OnPost()
    {
        if (ModelState.IsValid)
        {
            await _bookingService.Create(CreateBooking);
            TempData["success"] = "Kunden created successfully";
            //return RedirectToPage("Index");
        }
    }
}
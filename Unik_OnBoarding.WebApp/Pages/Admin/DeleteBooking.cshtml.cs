using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Admin;

public class DeleteBookingModel : PageModel
{
	private readonly IBookingService _bookingService;

	public DeleteBookingModel(IBookingService bookingService)
	{
		_bookingService = bookingService;
	}

	[BindProperty] public QueryBookingResultDto Drt { get; set; }

	public async Task<IActionResult> OnGet(Guid id)
	{
		if (id == null) return NotFound();

		try
		{
			Drt = await _bookingService.Get(id);
		}
		catch (Exception e)
		{
			ModelState.AddModelError(string.Empty, e.Message);
			return Page();
		}

		return Page();
	}


	public async Task<IActionResult> OnPost(Guid id)
	{
		if (!ModelState.IsValid)
			return Page();
		try
		{
			await _bookingService.Delete(id);
			return RedirectToPage("/Admin/BookingDashboard");
		}
		catch (DbUpdateConcurrencyException e)
		{
			ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
			return Page();
		}
	}
}
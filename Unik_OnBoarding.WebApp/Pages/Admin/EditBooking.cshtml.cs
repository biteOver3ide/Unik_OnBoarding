using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Admin;

public class EditBookingModel : PageModel
{
	private readonly IBookingService _bookingService;

	public EditBookingModel(IBookingService bookingService)
	{
		_bookingService = bookingService;
	}

	[BindProperty] public QueryBookingResultDto Urt { get; set; }

	public async Task<IActionResult> OnGet(Guid Id)
	{
		if (Id == null) return NotFound();

		try
		{
			Urt = await _bookingService.Get(Id);
		}
		catch (Exception e)
		{
			ModelState.AddModelError(string.Empty, e.Message);
			return Page();
		}

		return Page();
	}

	public async Task<IActionResult> OnPost()
	{
		if (!ModelState.IsValid)
			return Page();

		try
		{
			await _bookingService.Edit(Urt);
			return RedirectToPage("/Admin/BookingIndex");
		}
		catch (DbUpdateConcurrencyException e)
		{
			ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
			return Page();
		}
	}
}
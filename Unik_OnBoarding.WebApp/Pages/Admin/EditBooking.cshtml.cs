using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;
using Unik_OnBoarding.WebApp.Infrastructure.Implementation;

namespace Unik_OnBoarding.WebApp.Pages.Admin;

[BindProperties]
public class EditBookingModel : PageModel
{
	private readonly IBookingService _bookingService;
	private readonly IOpgaverService _opgaverService;
	private readonly IMedarbejderService _medarbejderService;
	private readonly IProjektService _projektService;


	public EditBookingModel(IBookingService bookingService, IOpgaverService opgaverService, IMedarbejderService medarbejderService, IProjektService projektService)
	{
		_bookingService = bookingService;
		_opgaverService = opgaverService;
		_medarbejderService = medarbejderService;
		_projektService = projektService;
	}

	public QueryBookingResultDto UrtBooking { get; set; }
	public IEnumerable<QueryProjektResultDto> ProjektList { get; set; }
	public IEnumerable<QueryMedarbejderResultDto> MedarbejderList { get; set; }
	public IEnumerable<QueryOpgaverResultDto> OpgaverList { get; set; }

	public async Task OnGet()
	{
		ProjektList = await _projektService.GetAll();
		MedarbejderList = await _medarbejderService.GetAll();
		OpgaverList = await _opgaverService.GetAll();

	}


	public async Task<IActionResult> OnGetById(Guid Id)
	{
		if (Id == null) return NotFound();

		try
		{
			UrtBooking = await _bookingService.Get(Id);
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
			await _bookingService.Edit(UrtBooking);
			return RedirectToPage("/Admin/BookingIndex");
		}
		catch (DbUpdateConcurrencyException e)
		{
			ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
			return Page();
		}
	}
}
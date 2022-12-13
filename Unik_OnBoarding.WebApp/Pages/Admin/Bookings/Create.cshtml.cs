using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Admin.Bookings;

[BindProperties]
public class CreateModel : PageModel
{
    private readonly IBookingService _bookingService;
    private readonly IKundeService _kundeService;
    private readonly IMedarbejderService _medarbejderService;
    private readonly IOpgaverService _opgaverService;
    private readonly IProjektService _projektService;


    public CreateModel(IBookingService bookingService, IKundeService kundeService,
        IProjektService projektService, IMedarbejderService medarbejderService, IOpgaverService opgaverService)
    {
        _bookingService = bookingService;
        _kundeService = kundeService;
        _projektService = projektService;
        _medarbejderService = medarbejderService;
        _opgaverService = opgaverService;
    }

    public CreateBookingDto Booking { get; set; }
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
    }


    public async Task <IActionResult> OnPost()
    {
        //ClearFieldErrors(key => key.Contains("RowVersion"));
        //if (!ModelState.IsValid) return Page();
        if (!ModelState.IsValid)

        try
        {
            await _bookingService.Create(Booking);
            TempData["success"] = "Kunden created successfully";
            return new RedirectToPageResult("Index");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, "Concurrency conflict");
            return Page();
        }
    }

    private void ClearFieldErrors(Func<string, bool> predicate)
    {
        foreach (var field in ModelState)
        {
            if (field.Value.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                if (predicate(field.Key))
                {
                    field.Value.ValidationState = Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Valid;
                }
            }
        }
    }
}
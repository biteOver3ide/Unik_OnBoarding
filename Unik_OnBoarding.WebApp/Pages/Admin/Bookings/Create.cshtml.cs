using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Immutable;
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


    public CreateModel ( IBookingService bookingService, IKundeService kundeService,
        IProjektService projektService, IMedarbejderService medarbejderService, IOpgaverService opgaverService )
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

    public async Task OnGet ( )
    {
        var KL = await _kundeService.GetAll( );
        if (KL != null)
        {
            KundeList = (IEnumerable<QueryKundeResultDto>)( from k in KL select new { k.Kid, k.Firmanavn }).ToList();
        }

        var PL= await _projektService.GetAll( );
        //check then
        ProjektList = (IEnumerable<QueryProjektResultDto>)( from p in PL select new { p.ProjektId, p.ProjektTitle } ).ToList( );

        var ML = await _medarbejderService.GetAll( );
        //cekc then
        MedarbejderList = (IEnumerable<QueryMedarbejderResultDto>)( from m in ML select new { m.MedarbejderId, m.Efternavn } ).ToList( );

        var OL = await _opgaverService.GetAll( );
        //check then 
        OpgaverList = (IEnumerable<QueryOpgaverResultDto>)( from o in OL select new { o.OpgaveId, o.OpgaveName } ).ToList( );

    }


    public async Task OnPost ( )
    {
        if (ModelState.IsValid)
        {
            await _bookingService.Create(Booking);
            TempData["success"] = "Kunden created successfully";
            //fillOut DropDoewn List Again
            OnGet( );
            //return RedirectToPage("Index");
        }
    }



}

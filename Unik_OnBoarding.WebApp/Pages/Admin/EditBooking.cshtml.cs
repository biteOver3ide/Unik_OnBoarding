using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
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
    //private readonly IOpgaverService _opgaverService;
    //private readonly IMedarbejderService _medarbejderService;
    //private readonly IProjektService _projektService;


    public EditBookingModel ( IBookingService bookingService/*, IOpgaverService opgaverService, IMedarbejderService medarbejderService, IProjektService projektService*/)
    {
        _bookingService = bookingService;
        //_opgaverService = opgaverService;
        //_medarbejderService = medarbejderService;
        //_projektService = projektService;
    }

    public UpdateBookingDto UrtBooking { get; set; }
    //public IEnumerable<QueryProjektResultDto> ProjektList { get; set; }
    //public IEnumerable<QueryMedarbejderResultDto> MedarbejderList { get; set; }
    //public IEnumerable<QueryOpgaverResultDto> OpgaverList { get; set; }

    //public async Task OnGet()
    //{
    //	ProjektList = await _projektService.GetAll();
    //	MedarbejderList = await _medarbejderService.GetAll();
    //	OpgaverList = await _opgaverService.GetAll();
    //}

    //****** To Do **********************************************************//
    //Display The Name Of Projetc,Opgave And Medarbejde Instead of Id??????????
    //***********************************************************************//
    public async Task<IActionResult> OnGetById ( Guid id )
    {
        {
            // Update Flow > 1-Get The object to update from db By Id
            //Will return QueryBookingResultDto
            //Then mapping to our objectToUpdate and send it agin to our Api
            //Whech expected and Object like this and then MediaTr well send 
            //an request which will be Automapped
            if (id == null) return NotFound( );

            QueryBookingResultDto dto = await _bookingService.Get(id);

            if (dto == null) return NotFound( );

            UrtBooking = new UpdateBookingDto
            {
                BookId = dto.BookId,
                ProjektId = dto.ProjektId,
                OpgaveId = dto.OpgaveId,
                MedarbejderId = dto.MedarbejderId,
                Duration = dto.Duration,
                Beskrivelse = dto.Beskrivelse,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                RowVersion = dto.RowVersion
            };
            return Page( );
        }
    }

    public async Task<IActionResult> OnPost ( )
    {
        if (!ModelState.IsValid)
            return Page( );

        try
        {
            await _bookingService.Edit(UrtBooking);
            return RedirectToPage("/Admin/BookingIndex");
        }
        catch (DbUpdateConcurrencyException e)
        {
            ModelState.AddModelError(string.Empty, $"Concurrency conflict {e}");
            return Page( );
        }
    }
}
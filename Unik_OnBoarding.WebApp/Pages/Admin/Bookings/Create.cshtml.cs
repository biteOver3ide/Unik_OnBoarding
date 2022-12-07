using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Pages.Admin.Bookings
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IBookingService _BookService;
        private readonly IKundeService _KundeService;
        private readonly IProjektService _ProjectService;
        private readonly IMedarbejderService _MarbejdeService;
        private readonly IOpgaverService _OpgaveService;

        public CreateModel(IBookingService bookService, IKundeService KundeService, IProjektService projectService
            , IMedarbejderService medarbejderService, IOpgaverService opgaverService)
        {
            this._BookService = bookService;
            this._KundeService = KundeService;
            this._ProjectService = projectService;
            this._MarbejdeService = medarbejderService;
            this._OpgaveService = opgaverService;
        }
        public BookingCreateDto Booking { get; set; }
        public IEnumerable<OpgaverDto> OpgaverList { get; set; }
        public IEnumerable<KundeDto> KunderList { get; set; }
        public IEnumerable<ProjektDto> ProjectsList { get; set; }
        public IEnumerable<MedarbejderDto> MedarbejderList { get; set; }
        public async Task OnGet()
        {
            OpgaverList = await _OpgaveService.GetAllDataAsync();
            MedarbejderList = await _MarbejdeService.GetAllDataAsync();
            ProjectsList = await _ProjectService.GetAllDataAsync(null);
            KunderList = await _KundeService.GetAllDataAsync();
        }


        public async Task OnPost()
        {
            if (ModelState.IsValid)
            {
                await _BookService.Create(Booking);
                TempData["success"] = "Kunden created successfully";
                //return RedirectToPage("Index");
            }
        }
    }
}

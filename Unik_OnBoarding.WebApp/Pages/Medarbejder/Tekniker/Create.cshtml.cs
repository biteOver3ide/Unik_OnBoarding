using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;
using Unik_OnBoarding.WebApp.Pages.Medarbejder.ViewModel;

namespace Unik_OnBoarding.WebApp.Pages.Medarbejder.Tekniker;

public class CreateModel : PageModel
{
    private readonly IMedarbejderService _medarbejderService;

    public CreateModel(IMedarbejderService medarbejderService)
    {
        _medarbejderService = medarbejderService;
    }

    [BindProperty] public MedarbejderCreateViewModel Model { get; set; } = new();

    public async Task<IActionResult> OnPost()
    {
        var dto = new MedarbejderCreateRequestDto
        {
            MedarbejderId = Model.MedarbejderId,Fornavn = Model.Fornavn, Efternavn = Model.Efternavn, Email = Model.Email, Job= Model.Job, Kompetencer = Model.Kompetencer, Telefon = Model.Telefon
        };
        try
        {
            await _medarbejderService.Create(dto);
        }
        catch (Exception e)
        {
            ModelState.AddModelError(string.Empty, e.Message);
            return Page();
        }


        return new RedirectToPageResult("/Medarbejder/Tekniker/Index");
    }
}
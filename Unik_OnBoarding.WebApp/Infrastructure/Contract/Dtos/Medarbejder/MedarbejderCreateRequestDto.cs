using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;

public class MedarbejderCreateRequestDto
{
    [Required] public string Fornavn { get; set; }

    public string Efternavn { get; set; }

    [EmailAddress]
    [Compare("GentageEmail")]
    [Required(ErrorMessage = "indtast en gyldig email")]
    public string Email { get; set; }

    public string GentageEmail { get; set; }

    [Required] public string Telefon { get; set; }

    public Jobtitler Job { get; set; }
}
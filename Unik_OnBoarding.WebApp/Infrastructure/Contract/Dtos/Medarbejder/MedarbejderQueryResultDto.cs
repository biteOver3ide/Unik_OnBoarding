using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;

public class MedarbejderQueryResultDto
{
    [Key] public Guid MedarbejderId { get; set; }

    [Required(ErrorMessage = "indtast et gyldig navn")]
    public string Fornavn { get; set; }

    [Required(ErrorMessage = "indtast et gyldig efternavn")]
    public string Efternavn { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "indtast en gyldig email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "indtast en gyldig telefon nummer")]
    public string Telefon { get; set; }

    public Jobtitler Job { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }
}
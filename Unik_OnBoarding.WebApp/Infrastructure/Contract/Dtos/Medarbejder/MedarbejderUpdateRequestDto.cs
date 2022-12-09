using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.Migrations;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;

public class MedarbejderUpdateRequestDto
{
    [Key] public Guid MedarbejderId { get; set; }

    [Required] public string Fornavn { get; set; }

    public string Efternavn { get; set; }

    [Required] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    public Jobtitler Job { get; set; }

    [Timestamp] public RowVersion RowVersion { get; set; }
}
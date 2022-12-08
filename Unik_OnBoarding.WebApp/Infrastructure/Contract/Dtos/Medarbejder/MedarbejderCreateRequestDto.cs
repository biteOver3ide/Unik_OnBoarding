using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;

public class MedarbejderCreateRequestDto
{
    [Required] public string Fornavn { get; set; }

    public string Efternavn { get; set; }

    [Required] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    public Jobtitler Job { get; set; }

    //public IReadOnlyCollection<KompetenceEntity>? Kompetencer { get; set; }

    //[Timestamp]
    //public byte[] RowVersion { get; set; }
}
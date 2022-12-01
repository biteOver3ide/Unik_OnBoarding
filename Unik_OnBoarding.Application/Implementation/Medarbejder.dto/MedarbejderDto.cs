using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Implementation.Medarbejder.dto;

public class MedarbejderDto
{
    [Key] public Guid MedarbejderId { get; set; }

    [Required] public string Fornavn { get; set; }

    public string Efternavn { get; set; }

    [Required] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    public Jobtitler Job { get; set; }

    public IReadOnlyCollection<KompetenceEntity>? Kompetencer { get; set; }
}
using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Implementation.Medarbejder.dto;

public class MedarbejderCreateDto
{
    public string Fornavn { get; set; }

    public string Efternavn { get; set; }

    public string Email { get; set; }

    public string Telefon { get; set; }

    //public Jobtitler Job { get; set; }

    //public IReadOnlyCollection<KompetenceEntity>? Kompetencer { get; set; }
}
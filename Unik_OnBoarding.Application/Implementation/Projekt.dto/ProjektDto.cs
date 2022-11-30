using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Implementation.Projekt.dto;

public class ProjektDto
{
    [Key] public Guid ProjektId { get; set; }

    [Required] public string ProjektTitle { get; set; }

    public KundeEntity Kunde { get; set; }

    public Guid KundeId { get; set; }
}
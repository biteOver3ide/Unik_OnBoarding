using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Application.DTO.Projekt;

public class ProjektDto
{
    [Key] public Guid ProjektId { get; set; }

    [Required] public string ProjektTitle { get; set; }

    public Domain.Kunde Kunde { get; set; }

    public Guid KundeId { get; set; }
}
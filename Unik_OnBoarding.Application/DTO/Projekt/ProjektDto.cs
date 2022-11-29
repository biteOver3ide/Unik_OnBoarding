namespace Unik_OnBoarding.Application.DTO.Projekt;

public class ProjektDto
{
    public Guid ProjektId { get; set; }

    public string ProjektTitle { get; set; }

    public Domain.Kunde Kunde { get; set; }

    public Guid KundeId { get; set; }
}
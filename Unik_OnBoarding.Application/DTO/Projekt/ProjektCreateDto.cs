using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unik_OnBoarding.Domain;

namespace Unik_OnBoarding.Application.DTO.Projekt;

public class ProjektCreateDto
{
    [Required]
    [DisplayName("Projekt title")]
    public string ProjektTitle { get; set; }

    [ForeignKey("KundeId")] // Realation mellem Projekt og Kunde 1 to many
    public Kunde Kunde { get; set; }

    public Guid KundeId { get; set; }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Unik_OnBoarding.Domain;

namespace Unik_OnBoarding.Application.DTO.Projekt;

public class ProjektUpdateDto
{
    [Key]
    public Guid ProjektId { get; set; }

    [Required]
    [DisplayName("Projekt title")]
    public string ProjektTitle { get; set; }

    [ForeignKey("KundeId")] // Realation mellem Projekt og Kunde 1 to many
    public Domain.Kunde Kunde { get; set; }

    public Guid KundeId { get; set; }
}
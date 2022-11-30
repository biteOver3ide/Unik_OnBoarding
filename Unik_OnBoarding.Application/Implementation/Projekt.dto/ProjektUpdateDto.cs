using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Implementation.Projekt.dto;

public class ProjektUpdateDto
{
    [Key] public Guid ProjektId { get; set; }

    [Required]
    [DisplayName("Projekt title")]
    public string? ProjektTitle { get; set; }

    [ForeignKey("KundeId")] // Realation mellem Projekt og Kunde 1 to many
    public KundeEntity Kunde { get; set; }

    public Guid KundeId { get; set; }
}
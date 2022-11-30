using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unik_OnBoarding.Domain;

public class Projekt
{
    [Key] public Guid ProjektId { get; set; }

    [Required] public string ProjektTitle { get; set; }

    [ForeignKey("KundeId")] // Realation mellem Projekt og Kunde 1 to many
    public Kunde Kunde { get; set; }

    public Guid KundeId { get; set; }
}
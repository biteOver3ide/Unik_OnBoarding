using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unik_OnBoarding.Domain.Model;

public class ProjektEntity
{
    [Key] public Guid ProjektId { get; set; }

    [Required] public string ProjektTitle { get; set; }

    public Guid KundeId { get; set; }

    [ForeignKey("KundeId")] public KundeEntity Kunde { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }
}
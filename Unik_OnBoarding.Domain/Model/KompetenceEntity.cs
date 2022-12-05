using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Domain.Model;

public class KompetenceEntity
{
    [Key]
    public Guid KompetenceId { get; set; }
    public string KompetenceName { get; set; }
    public string Beskrivelse { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }
}
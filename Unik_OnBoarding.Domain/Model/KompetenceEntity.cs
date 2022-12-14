using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Unik_OnBoarding.Domain.Model;

public class KompetenceEntity
{
    [Key] public Guid KompetenceId { get; set; }

    [Required] public Jobtitler Job { get; set; }

    [Required] public string? Beskrivelse { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }

}
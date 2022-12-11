using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Domain.Model;

public class MedarbejderEntity
{
    [Key] public Guid MedarbejderId { get; set; }

    [Required] public string Fornavn { get; set; }

    [Required] public string Efternavn { get; set; }

    [Required] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    public Jobtitler Job { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }
}   
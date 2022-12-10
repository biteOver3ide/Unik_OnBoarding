using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Domain.Model;

public class KundeEntity
{
    [Key] // Server side validation
    public Guid Kid { get; set; }

    [Required] public string Fornavn { get; set; }

    [Required] public string Efternavn { get; set; }

    [Required] public string Firmanavn { get; set; }

    [Required] public int Cvr { get; set; }

    [Required] [EmailAddress] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    [Required] public string Adresse { get; set; }

    // Navigation prop
    public List<ProjektEntity>? Projekt { get; set; } // En kunde kunde har null eller flere Projekt (derfor har vi set et ?)

    [Timestamp] public byte[] RowVersion { get; set; }
}
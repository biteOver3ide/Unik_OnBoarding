using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Application.Implementation.Kunde.dto;

public class KundeUpdateDto
{
    [Key] public Guid Kid { get; set; }

    public string Name { get; set; }

    [Required] public string Adresse { get; set; }

    [Required] [EmailAddress] public string Email { get; set; }

    public int Telefon { get; set; }
}
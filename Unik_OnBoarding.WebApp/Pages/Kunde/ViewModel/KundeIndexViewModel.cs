using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.WebApp.Pages.Kunde.ViewModel;

public class KundeIndexViewModel
{
    [Key] public Guid Kid { get; set; }

    public string Name { get; set; }

    [Required] public string Adresse { get; set; }

    [Required][EmailAddress] public string Email { get; set; }

    public int Telefon { get; set; }
}
namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;

public class KundeQueryResultDto
{
    public Guid Kid { get; set; }
    public string Name { get; set; }
    public string Adresse { get; set; }
    public string Email { get; set; }
    public int Telefon { get; set; }
}
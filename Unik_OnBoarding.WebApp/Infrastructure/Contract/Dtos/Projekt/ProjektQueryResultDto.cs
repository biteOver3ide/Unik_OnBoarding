namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;

public class ProjektQueryResultDto
{
    public Guid ProjektId { get; set; }
    public string ProjektTitle { get; set; }
    public byte[] RowVersion { get; set; }
}
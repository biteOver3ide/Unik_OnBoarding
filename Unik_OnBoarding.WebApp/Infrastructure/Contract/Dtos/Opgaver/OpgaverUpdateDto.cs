namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;

public class OpgaverUpdateDto
{
    public Guid OpgaveId { get; set; }
    public string OpgaveName { get; set; }
    public string Beskrivelse { get; set; }
    public byte[] RowVersion { get; set; }
}
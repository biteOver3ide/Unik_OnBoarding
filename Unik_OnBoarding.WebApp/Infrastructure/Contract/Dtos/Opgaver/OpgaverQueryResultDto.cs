namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;

public class OpgaverQueryResultDto
{
    public Guid OpgaveId { get; set; }
    public string OpgaveName { get; set; }
    public string Beskrivelse { get; set; }
    public byte[] RowVersion { get; set; }
}
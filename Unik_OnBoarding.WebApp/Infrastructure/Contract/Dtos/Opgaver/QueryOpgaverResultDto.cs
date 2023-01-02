using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;

public class QueryOpgaverResultDto
{
    public Guid OpgaveId { get; set; }
    public string OpgaveName { get; set; }
    public string Beskrivelse { get; set; }
    [Timestamp] public byte[] RowVersion { get; set; }
}
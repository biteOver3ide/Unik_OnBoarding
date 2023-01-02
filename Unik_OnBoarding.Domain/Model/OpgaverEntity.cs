using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unik_OnBoarding.Domain.Model;

public class OpgaverEntity
{
	[Key] public Guid OpgaveId { get; set; }

	[Required] public string OpgaveName { get; set; }

	[Required] public string Beskrivelse { get; set; }

	[Timestamp] public byte[] RowVersion { get; set; }
}
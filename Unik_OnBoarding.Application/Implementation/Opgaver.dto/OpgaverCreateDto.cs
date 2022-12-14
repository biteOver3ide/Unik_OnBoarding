using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Application.Implementation.Opgaver.dto;

public class OpgaverCreateDto
{
    public Guid OpgaveId { get; set; }

    public string OpgaveName { get; set; }

    public string Beskrivelse { get; set; }
}
using MediatR;

namespace Unik_OnBoarding.Application.Features.Opgaver.Command.UpdateOpgaver;

public class UpdateOpgaverCommand : IRequest
{
    public Guid OpgaveId { get; set; }
    public string OpgaveName { get; set; }
    public string Beskrivelse { get; set; }
}
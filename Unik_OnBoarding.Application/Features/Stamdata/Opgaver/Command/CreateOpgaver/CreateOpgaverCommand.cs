using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Opgaver.Command.CreateOpgaver;

public class CreateOpgaverCommand : IRequest<Guid>
{
    public Guid OpgaveId { get; set; }
    public string OpgaveName { get; set; }
    public string Beskrivelse { get; set; }
}
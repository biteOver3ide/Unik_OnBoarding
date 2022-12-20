using MediatR;

namespace Unik_OnBoarding.Application.Features.Opgaver.Command.CreateOpgaver;

public class CreateOpgaverCommand : IRequest<Guid>
{
	public string OpgaveName { get; set; }
    public string Beskrivelse { get; set; }
}
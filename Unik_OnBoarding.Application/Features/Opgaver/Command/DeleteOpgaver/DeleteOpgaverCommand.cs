using MediatR;

namespace Unik_OnBoarding.Application.Features.Opgaver.Command.DeleteOpgaver;

public class DeleteOpgaverCommand : IRequest
{
    public Guid OpgaveId { get; set; }
}
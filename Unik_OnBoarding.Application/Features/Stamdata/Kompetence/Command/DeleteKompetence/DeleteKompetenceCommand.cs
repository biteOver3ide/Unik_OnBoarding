using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.DeleteKompetence;

public class DeleteKompetenceCommand : IRequest
{
    public Guid KompetenceId { get; set; }
}
using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Command.DeleteProjekt;

public class DeleteProjektCommand : IRequest
{
    public Guid ProjektId { get; set; }
}
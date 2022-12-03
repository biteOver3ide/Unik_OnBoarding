using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Projekt.Command.DeleteProjekt;

public class DeleteProjektCommand : IRequest
{
    public Guid ProjektId { get; set; }
}
using MediatR;

namespace Unik_OnBoarding.Application.Features.Projekt.Command.CreateProjekt;

public class CreateProjektCommand : IRequest<Guid>
{
    public string ProjektTitle { get; set; }

    public Guid KundeId { get; set; }
}
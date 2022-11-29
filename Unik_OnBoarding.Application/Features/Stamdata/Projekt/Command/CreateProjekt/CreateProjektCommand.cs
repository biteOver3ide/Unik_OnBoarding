using MediatR;
using Unik_OnBoarding.Application.DTO.Projekt;

namespace Unik_OnBoarding.Application.Features.Stamdata.Command.CreateProjekt;

public class CreateProjektCommand : IRequest<Guid>
{
    public string ProjektTitle { get; set; }

    public Guid KundeId { get; set; }
}
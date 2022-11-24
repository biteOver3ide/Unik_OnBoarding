using MediatR;
using Unik_OnBoarding.Domain;

namespace Unik_OnBoarding.Application.Features.Stamdata.Command.CreateProjekt;

public class CreateProjektCommand : IRequest<Guid>
{
    public Projekt CreateNewProjektDto { get; set; }
}
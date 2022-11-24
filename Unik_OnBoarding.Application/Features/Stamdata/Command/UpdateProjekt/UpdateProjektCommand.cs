using MediatR;
using Unik_OnBoarding.Application.DTO.Projekt;

namespace Unik_OnBoarding.Application.Features.Stamdata.Command.UpdateProjekt;

public class UpdateProjektCommand : IRequest
{
    public ProjektUpdateDto UpdateProjektDto { get; set; }
}
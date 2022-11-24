using MediatR;
using Unik_OnBoarding.Application.DTO.Projekt;

namespace Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektDetail;

public class GetProjektDetailQuery : IRequest<ProjektDto>
{
    public Guid ProjektId { get; set; }
}
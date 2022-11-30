using MediatR;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;

namespace Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektDetail;

public class GetProjektDetailQuery : IRequest<ProjektDto>
{
    public Guid ProjektId { get; set; }
}
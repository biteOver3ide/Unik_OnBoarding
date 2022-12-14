using MediatR;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;

namespace Unik_OnBoarding.Application.Features.Projekt.Queries.GetProjektList;

public class GetProjektListQuery : IRequest<List<ProjektDto>>
{
}
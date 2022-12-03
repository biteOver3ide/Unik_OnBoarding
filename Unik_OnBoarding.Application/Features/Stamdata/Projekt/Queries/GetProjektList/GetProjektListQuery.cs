using MediatR;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;

namespace Unik_OnBoarding.Application.Features.Stamdata.Projekt.Queries.GetProjektList;

public class GetProjektListQuery : IRequest<List<ProjektDto>>
{
}
using MediatR;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;

namespace Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektList;

public class GetProjektListQuery : IRequest<List<ProjektDto>>
{
}
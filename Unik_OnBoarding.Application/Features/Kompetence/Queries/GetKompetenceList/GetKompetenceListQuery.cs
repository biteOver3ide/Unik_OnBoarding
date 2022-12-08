using MediatR;
using Unik_OnBoarding.Application.Implementation.Kompetencer.dto;

namespace Unik_OnBoarding.Application.Features.Kompetence.Queries.GetKompetenceList;

public class GetKompetenceListQuery : IRequest<List<KompetenceDto>>
{
}
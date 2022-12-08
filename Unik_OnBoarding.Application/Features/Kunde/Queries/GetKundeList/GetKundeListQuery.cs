using MediatR;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;

namespace Unik_OnBoarding.Application.Features.Kunde.Queries.GetKundeList;

public class GetKundeListQuery : IRequest<List<KundeDto>>
{
}
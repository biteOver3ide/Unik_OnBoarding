using MediatR;
using Unik_OnBoarding.Application.DTO.Kunde;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Queries.GetKundeList;

public class GetKundeListQuery : IRequest<List<KundeDto>>
{
    
}
using MediatR;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;

namespace Unik_OnBoarding.Application.Features.Kunde.Queries.GetKundeDetail;

public class GetKundeDetailQuery : IRequest<KundeDto>
{
    public Guid Kid { get; set; }
}
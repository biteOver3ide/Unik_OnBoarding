using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.DTO.Kunde;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Queries.GetKundeList;

public class GetKundeListQueryHandler : IRequestHandler<GetKundeListQuery, List<KundeDto>>
{
    private readonly IKundeRepository _kundeRepository;
    private readonly IMapper _mapper;

    public GetKundeListQueryHandler(IKundeRepository kundeRepository, IMapper mapper)
    {
        _kundeRepository = kundeRepository;
        _mapper = mapper;
    }

    async Task<List<KundeDto>> IRequestHandler<GetKundeListQuery, List<KundeDto>>.Handle(
        GetKundeListQuery request,
        CancellationToken cancellationToken)
    {
        var kundeFromDb = await _kundeRepository.GetAllKundeAsync(true);
        return _mapper.Map<List<KundeDto>>(kundeFromDb);
    }
}
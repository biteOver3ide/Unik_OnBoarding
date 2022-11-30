using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Queries.GetKundeDetail;

public class GetKundeDetailQueryHandler : IRequestHandler<GetKundeDetailQuery, KundeDto>
{
    private readonly IKundeRepository _kundeRepository;
    private readonly IMapper _mapper;

    public GetKundeDetailQueryHandler(IKundeRepository kundeRepository, IMapper mapper)
    {
        _kundeRepository = kundeRepository;
        _mapper = mapper;
    }


    async Task<KundeDto> IRequestHandler<GetKundeDetailQuery, KundeDto>.Handle(GetKundeDetailQuery request,
        CancellationToken cancellationToken)
    {
        var kundeFromDb = await _kundeRepository.GetKundeByIdAsync(request.Kid);
        return _mapper.Map<KundeDto>(kundeFromDb);
    }
}
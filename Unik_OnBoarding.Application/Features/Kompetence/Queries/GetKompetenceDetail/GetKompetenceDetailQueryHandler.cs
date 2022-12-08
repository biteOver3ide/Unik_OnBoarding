using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Kompetencer.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Kompetence.Queries.GetKompetenceDetail;

public class GetKompetenceDetailQueryHandler : IRequestHandler<GetKompetenceDetailQuery, KompetenceDto>
{
    private readonly IKompetencerRepository _kompetencerRepository;
    private readonly IMapper _mapper;

    public GetKompetenceDetailQueryHandler(IKompetencerRepository kompetencerRepository, IMapper mapper)
    {
        _kompetencerRepository = kompetencerRepository;
        _mapper = mapper;
    }

    public async Task<KompetenceDto> Handle(GetKompetenceDetailQuery request, CancellationToken cancellationToken)
    {
        var kompetenceFromDb = await _kompetencerRepository.GetKompetencerByIdAsync(request.KompetencerId);
        return _mapper.Map<KompetenceDto>(kompetenceFromDb);
    }
}
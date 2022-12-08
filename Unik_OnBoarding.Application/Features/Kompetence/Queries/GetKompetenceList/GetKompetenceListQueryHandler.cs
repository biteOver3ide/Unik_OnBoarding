using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Kompetencer.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Kompetence.Queries.GetKompetenceList;

public class GetKompetenceListQueryHandler : IRequestHandler<GetKompetenceListQuery, List<KompetenceDto>>
{
    private readonly IKompetencerRepository _kompetencerRepository;
    private readonly IMapper _mapper;

    public GetKompetenceListQueryHandler(IKompetencerRepository kompetencerRepository, IMapper mapper)
    {
        _kompetencerRepository = kompetencerRepository;
        _mapper = mapper;
    }

    public async Task<List<KompetenceDto>> Handle(GetKompetenceListQuery request, CancellationToken cancellationToken)
    {
        var kompetenceFromDb = await _kompetencerRepository.GetAllKompetencerAsync();
        return _mapper.Map<List<KompetenceDto>>(kompetenceFromDb);
    }
}
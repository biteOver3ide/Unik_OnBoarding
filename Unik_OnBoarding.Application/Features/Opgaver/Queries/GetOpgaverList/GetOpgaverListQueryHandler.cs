using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Opgaver.Queries.GetOpgaverList;

public class GetOpgaverListQueryHandler : IRequestHandler<GetOpgaverListQuery, List<OpgaverDto>>
{
    private readonly IOpgaverRepository _opgaverRepository;
    private readonly IMapper _mapper;

    public GetOpgaverListQueryHandler(IOpgaverRepository opgaverRepository, IMapper mapper)
    {
        _opgaverRepository = opgaverRepository;
        _mapper = mapper;
    }

    public async Task<List<OpgaverDto>> Handle(GetOpgaverListQuery request, CancellationToken cancellationToken)
    {
        var opgaveFromDb = await _opgaverRepository.GetAllOpgaverAsync();
        return _mapper.Map<List<OpgaverDto>>(opgaveFromDb);
    }
}
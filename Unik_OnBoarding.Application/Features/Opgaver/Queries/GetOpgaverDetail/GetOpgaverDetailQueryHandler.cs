using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Opgaver.Queries.GetOpgaverDetail;

public class GetOpgaverDetailQueryHandler : IRequestHandler<GetOpgaverDetailQuery, OpgaverDto>
{
    private readonly IOpgaverRepository _opgaverRepository;
    private readonly IMapper _mapper;

    public GetOpgaverDetailQueryHandler(IOpgaverRepository opgaverRepository, IMapper mapper)
    {
        _opgaverRepository = opgaverRepository;
        _mapper = mapper;
    }

    public async Task<OpgaverDto> Handle(GetOpgaverDetailQuery request, CancellationToken cancellationToken)
    {
        var opgaveFromDb = await _opgaverRepository.GetOpgaverByIdAsync(request.OpgaverId);
        return _mapper.Map<OpgaverDto>(opgaveFromDb);
    }
}
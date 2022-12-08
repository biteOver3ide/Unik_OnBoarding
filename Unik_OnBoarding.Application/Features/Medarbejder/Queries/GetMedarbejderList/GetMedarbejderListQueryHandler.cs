using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Queries.GetMedarbejderList;

public class GetMedarbejderListQueryHandler : IRequestHandler<GetMedarbejderListQuery, List<MedarbejderDto>>
{
    private readonly IMapper _mapper;
    private readonly IMedarbejderRepository _medarbejderRepository;

    public GetMedarbejderListQueryHandler(IMedarbejderRepository medarbejderRepository, IMapper mapper)
    {
        _medarbejderRepository = medarbejderRepository;
        _mapper = mapper;
    }

    public async Task<List<MedarbejderDto>> Handle(GetMedarbejderListQuery request, CancellationToken cancellationToken)
    {
        var medarbejderFromDb = await _medarbejderRepository.GetAllMedarbejderAsync(true);
        return _mapper.Map<List<MedarbejderDto>>(medarbejderFromDb);
    }
}
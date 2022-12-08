using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Queries.GetMedarbejderDetail;

public class GetMedarbejderDetailQueryHandler : IRequestHandler<GetMedarbejderDetailQuery, MedarbejderDto>
{
    private readonly IMapper _mapper;
    private readonly IMedarbejderRepository _medarbejderRepository;

    public GetMedarbejderDetailQueryHandler(IMedarbejderRepository medarbejderRepository, IMapper mapper)
    {
        _medarbejderRepository = medarbejderRepository;
        _mapper = mapper;
    }

    public async Task<MedarbejderDto> Handle(GetMedarbejderDetailQuery request, CancellationToken cancellationToken)
    {
        var medarbejderFromDb = await _medarbejderRepository.GetMedarbejderByIdAsync(request.MedarbejderId);
        return _mapper.Map<MedarbejderDto>(medarbejderFromDb);
    }
}
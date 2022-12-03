using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Stamdata.Projekt.Queries.GetProjektDetail;

public class GetProjektDetailQueryHandler : IRequestHandler<GetProjektDetailQuery, ProjektDto>
{
    private readonly IMapper _mapper;
    private readonly IProjectRepository _projectRepository;

    public GetProjektDetailQueryHandler(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }

    async Task<ProjektDto> IRequestHandler<GetProjektDetailQuery, ProjektDto>.Handle(GetProjektDetailQuery request,
        CancellationToken cancellationToken)
    {
        var projektFromDb = await _projectRepository.GetProjektByIdAsync(request.ProjektId);
        return _mapper.Map<ProjektDto>(projektFromDb);
    }
}
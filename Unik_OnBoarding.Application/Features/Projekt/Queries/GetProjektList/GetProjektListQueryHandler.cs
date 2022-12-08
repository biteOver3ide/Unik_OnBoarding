using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Projekt.Queries.GetProjektList;

public class GetProjektListQueryHandler : IRequestHandler<GetProjektListQuery, List<ProjektDto>>
{
    private readonly IMapper _mapper;
    private readonly IProjectRepository _projectRepository;

    public GetProjektListQueryHandler(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }

    async Task<List<ProjektDto>> IRequestHandler<GetProjektListQuery, List<ProjektDto>>.Handle(
        GetProjektListQuery request,
        CancellationToken cancellationToken)
    {
        var projektsFromDb = await _projectRepository.GetAllProjektAsync(true);
        return _mapper.Map<List<ProjektDto>>(projektsFromDb);
    }
}
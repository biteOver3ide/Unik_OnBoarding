using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.DTO.Projekt;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Stamdata.Queries.GetProjektList;

public class GetProjektListQueryHandler : IRequestHandler<GetProjektListQuery, List<ProjectViewModel>>
{
    private readonly IMapper _mapper;
    private readonly IProjectRepository _projectRepository;

    public GetProjektListQueryHandler(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }

    async Task<List<ProjectViewModel>> IRequestHandler<GetProjektListQuery, List<ProjectViewModel>>.Handle(
        GetProjektListQuery request,
        CancellationToken cancellationToken)
    {
        var projektsFromDb = await _projectRepository.GetAllProjektAsync(true);
        return _mapper.Map<List<ProjectViewModel>>(projektsFromDb);
    }
}
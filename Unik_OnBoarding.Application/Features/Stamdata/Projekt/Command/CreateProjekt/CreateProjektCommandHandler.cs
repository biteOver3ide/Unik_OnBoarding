using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain;

namespace Unik_OnBoarding.Application.Features.Stamdata.Command.CreateProjekt;

public class CreateProjektCommandHandler : IRequestHandler<CreateProjektCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IProjectRepository _projectRepository;

    public CreateProjektCommandHandler(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }

    async Task<Guid> IRequestHandler<CreateProjektCommand, Guid>.Handle(CreateProjektCommand request,
        CancellationToken cancellationToken)
    {
        var projekt = _mapper.Map<Projekt>(request);

        CreateProjektValidator validator = new();
        var result = await validator.ValidateAsync(request);

        if (result.Errors.Any()) throw new Exception("Forkert indtastning");

        projekt = await _projectRepository.AddAsync(projekt);
        return projekt.ProjektId;
    }
}
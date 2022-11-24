using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.DTO.Projekt;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain;

namespace Unik_OnBoarding.Application.Features.Stamdata.Command.UpdateProjekt;

public class UpdateProjektHandler : IRequestHandler<UpdateProjektCommand>
{
    private readonly IProjectRepository _projectRepository;
    private readonly IMapper _mapper;

    public UpdateProjektHandler(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }

    // no return type
    async Task<Unit> IRequestHandler<UpdateProjektCommand, Unit>.Handle(UpdateProjektCommand request, CancellationToken cancellationToken)
    {
        var projekt = _mapper.Map<Projekt>(request);

        UpdateCommandValidator updateCommandValidator = new();
        var result = await updateCommandValidator.ValidateAsync(request);

        if (result.Errors.Any())
        {
            throw new Exception("Vendlist check din input");
        }

        await _projectRepository.UpdateAsync(projekt);

        return Unit.Value;
    }
}
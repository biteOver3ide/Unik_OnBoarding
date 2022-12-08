using MediatR;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Projekt.Command.DeleteProjekt;

public class DeleteProjektCommandHandler : IRequestHandler<DeleteProjektCommand>
{
    private readonly IProjectRepository _projectRepository;

    public DeleteProjektCommandHandler(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<Unit> Handle(DeleteProjektCommand request,
        CancellationToken cancellationToken)
    {
        var projektFromDb = await _projectRepository.GetByIdAsync(request.ProjektId);

        await _projectRepository.DeleteAsync(projektFromDb);
        return Unit.Value;
    }
}
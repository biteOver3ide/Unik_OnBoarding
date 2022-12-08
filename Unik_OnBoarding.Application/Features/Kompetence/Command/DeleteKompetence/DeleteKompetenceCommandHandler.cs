using MediatR;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Kompetence.Command.DeleteKompetence;

public class DeleteKompetenceCommandHandler : IRequestHandler<DeleteKompetenceCommand>
{
    private readonly IKompetencerRepository _kompetencerRepository;

    public DeleteKompetenceCommandHandler(IKompetencerRepository kompetencerRepository)
    {
        _kompetencerRepository = kompetencerRepository;
    }

    public async Task<Unit> Handle(DeleteKompetenceCommand request, CancellationToken cancellationToken)
    {
        var kompetenceFromDb = await _kompetencerRepository.GetByIdAsync(request.KompetenceId);

        await _kompetencerRepository.DeleteAsync(kompetenceFromDb);
        return Unit.Value;
    }
}
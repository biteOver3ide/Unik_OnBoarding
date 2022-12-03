using MediatR;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.DeleteKunde;

public class DeleteKunderCommandHandler : IRequestHandler<DeleteKunderCommand>
{
    private readonly IKundeRepository _kundeRepository;

    public DeleteKunderCommandHandler(IKundeRepository kundeRepository)
    {
        _kundeRepository = kundeRepository;
    }


    public async Task<Unit> Handle(DeleteKunderCommand request, CancellationToken cancellationToken)
    {
        var kundeFromDb = await _kundeRepository.GetByIdAsync(request.Kid);

        await _kundeRepository.DeleteAsync(kundeFromDb);
        return Unit.Value;
    }
}
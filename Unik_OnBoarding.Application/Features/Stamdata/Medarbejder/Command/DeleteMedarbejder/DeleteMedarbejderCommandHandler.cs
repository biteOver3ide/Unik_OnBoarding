using MediatR;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Command.DeleteMedarbejder;

public class DeleteMedarbejderCommandHandler : IRequestHandler<DeleteMedarbejderCommand>
{
    private readonly IMedarbejderRepository _medarbejderRepository;

    public DeleteMedarbejderCommandHandler(IMedarbejderRepository medarbejderRepository)
    {
        _medarbejderRepository = medarbejderRepository;
    }

    public async Task<Unit> Handle(DeleteMedarbejderCommand request, CancellationToken cancellationToken)
    {
        var MedarbejderFromDb = await _medarbejderRepository.GetByIdAsync(request.MedarbejderId);

        await _medarbejderRepository.DeleteAsync(MedarbejderFromDb);
        return Unit.Value;
    }
}
using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Stamdata.Opgaver.Command.DeleteOpgaver;

public class DeleteOpgaverCommandHandler : IRequestHandler<DeleteOpgaverCommand>
{
    private readonly IOpgaverRepository _opgaverRepository;
    private readonly IMapper _mapper;

    public DeleteOpgaverCommandHandler(IOpgaverRepository opgaverRepository, IMapper mapper)
    {
        _opgaverRepository = opgaverRepository;
        _mapper = mapper;
    }
    public async Task<Unit> Handle(DeleteOpgaverCommand request, CancellationToken cancellationToken)
    {
        var opgaveFromDb = await _opgaverRepository.GetOpgaverByIdAsync(request.OpgaveId);

        await _opgaverRepository.DeleteAsync(opgaveFromDb);
        return Unit.Value;
    }
}
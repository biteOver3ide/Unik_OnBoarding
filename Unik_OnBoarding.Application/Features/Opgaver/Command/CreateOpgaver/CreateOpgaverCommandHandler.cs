using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Opgaver.Command.CreateOpgaver;

public class CreateOpgaverCommandHandler : IRequestHandler<CreateOpgaverCommand, Guid>
{
    private readonly IOpgaverRepository _opgaverRepository;
    private readonly IMapper _mapper;

    public CreateOpgaverCommandHandler(IOpgaverRepository opgaverRepository, IMapper mapper)
    {
        _opgaverRepository = opgaverRepository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateOpgaverCommand request, CancellationToken cancellationToken)
    {
        var opgaver = _mapper.Map<OpgaverEntity>(request);

        CreateOpgaverValidator validator = new();
        var result = await validator.ValidateAsync(request);

        if (result.Errors.Any()) throw new Exception("Forkert indtasting");

        opgaver = await _opgaverRepository.AddAsync(opgaver);
        return opgaver.OpgaveId;

    }
}
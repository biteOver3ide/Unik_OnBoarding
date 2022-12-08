using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Opgaver.Command.UpdateOpgaver;

public class UpdateOpgaverCommandHandler : IRequestHandler<UpdateOpgaverCommand>
{
    private readonly IMapper _mapper;
    private readonly IOpgaverRepository _opgaverRepository;

    public UpdateOpgaverCommandHandler(IOpgaverRepository opgaverRepository, IMapper mapper)
    {
        _opgaverRepository = opgaverRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateOpgaverCommand request, CancellationToken cancellationToken)
    {
        var opgave = _mapper.Map<OpgaverEntity>(request);

        try
        {
            UpdateOpgaverValidator updateOpgaverValidator = new();
            var result = await updateOpgaverValidator.ValidateAsync(request);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        await _opgaverRepository.UpdateAsync(opgave);

        return Unit.Value;
    }
}
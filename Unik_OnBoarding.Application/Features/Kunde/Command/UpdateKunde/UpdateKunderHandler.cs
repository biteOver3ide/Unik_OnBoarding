using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Kunde.Command.UpdateKunde;

public class UpdateKunderHandler : IRequestHandler<UpdateKunderCommand>
{
    private readonly IKundeRepository _kundeRepository;
    private readonly IMapper _mapper;

    public UpdateKunderHandler(IKundeRepository kundeRepository, IMapper mapper)
    {
        _kundeRepository = kundeRepository;
        _mapper = mapper;
    }

    async Task<Unit> IRequestHandler<UpdateKunderCommand, Unit>.Handle(UpdateKunderCommand request,
        CancellationToken cancellationToken)
    {
        var kunder = _mapper.Map<KundeEntity>(request);

        try
        {
            UpdateCommandKundeValidator updateCommandKundeValidator = new();
            var result = await updateCommandKundeValidator.ValidateAsync(request);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        await _kundeRepository.UpdateAsync(kunder);

        return Unit.Value;
    }
}
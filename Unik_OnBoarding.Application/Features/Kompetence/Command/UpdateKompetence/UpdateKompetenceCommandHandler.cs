using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Kompetence.Command.UpdateKompetence;

public class UpdateKompetenceCommandHandler : IRequestHandler<UpdateKompetenceCommand>
{
    private readonly IKompetencerRepository _kompetencerRepository;
    private readonly IMapper _mapper;

    public UpdateKompetenceCommandHandler(IKompetencerRepository kompetencerRepository, IMapper mapper)
    {
        _kompetencerRepository = kompetencerRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateKompetenceCommand request, CancellationToken cancellationToken)
    {
        var kompetence = _mapper.Map<KompetenceEntity>(request);

        try
        {
            UpdateKompetenceValidator kompetenceValidator = new();
            var result = await kompetenceValidator.ValidateAsync(request);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        await _kompetencerRepository.UpdateAsync(kompetence);

        return Unit.Value;
    }
}
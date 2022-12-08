using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Kompetence.Command.CreateKompetence;

public class CreateKompetenceCommandHandler : IRequestHandler<CreateKompetenceCommand, Guid>
{
    private readonly IKompetencerRepository _kompetencerRepository;
    private readonly IMapper _mapper;

    public CreateKompetenceCommandHandler(IKompetencerRepository kompetencerRepository, IMapper mapper)
    {
        _kompetencerRepository = kompetencerRepository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateKompetenceCommand request, CancellationToken cancellationToken)
    {
        var kompetencer = _mapper.Map<KompetenceEntity>(request);

        CreateKompetenceValidator validator = new();
        var result = await validator.ValidateAsync(request);

        if (result.Errors.Any()) throw new Exception("Forket indtasting");

        kompetencer = await _kompetencerRepository.AddAsync(kompetencer);
        return kompetencer.KompetenceId;
    }
}
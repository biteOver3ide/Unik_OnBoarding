using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Kunde.Command.CreateKunde;

public class CreateKunderCommandHandler : IRequestHandler<CreateKunderCommand, Guid>
{
    private readonly IKundeRepository _kundeRepository;
    private readonly IMapper _mapper;

    public CreateKunderCommandHandler(IKundeRepository kundeRepository, IMapper mapper)
    {
        _kundeRepository = kundeRepository;
        _mapper = mapper;
    }

    async Task<Guid> IRequestHandler<CreateKunderCommand, Guid>.Handle(CreateKunderCommand request, CancellationToken cancellationToken)
    {
        var kunder = _mapper.Map<KundeEntity>(request);

        CreateKunderValidator validator = new();
        var result = await validator.ValidateAsync(request);

        if (result.Errors.Any()) throw new Exception("Forket indtastning");

        kunder = await _kundeRepository.AddAsync(kunder);
        return kunder.Kid;
    }
}
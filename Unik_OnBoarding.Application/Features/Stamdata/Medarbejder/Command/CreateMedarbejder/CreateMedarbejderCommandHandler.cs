using AutoMapper;
using MediatR;
using Microsoft.VisualBasic;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Command.CreateMedarbejder;

public class CreateMedarbejderCommandHandler : IRequestHandler<CreateMedarbejderCommand, Guid>
{
    private readonly IMedarbejderRepository _medarbejderRepository;
    private readonly IMapper _mapper;

    public CreateMedarbejderCommandHandler(IMedarbejderRepository medarbejderRepository, IMapper mapper)
    {
        _medarbejderRepository = medarbejderRepository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateMedarbejderCommand request, CancellationToken cancellationToken)
    {
        var medarbejder = _mapper.Map<MedarbejderEntity>(request);

        CreateMedarbejderValidator validator = new();
        var result = await validator.ValidateAsync(request);

        if (result.Errors.Any()) throw new Exception("Forket indtastning");

        medarbejder = await _medarbejderRepository.AddAsync(medarbejder);
        return medarbejder.MedarbejderId;
    }
}
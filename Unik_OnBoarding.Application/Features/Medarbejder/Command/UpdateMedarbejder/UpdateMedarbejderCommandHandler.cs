using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Command.UpdateMedarbejder;

public class UpdateMedarbejderCommandHandler : IRequestHandler<UpdateMedarbejderCommand>
{
    private readonly IMapper _mapper;
    private readonly IMedarbejderRepository _medarbejderRepository;

    public UpdateMedarbejderCommandHandler(IMedarbejderRepository medarbejderRepository, IMapper mapper)
    {
        _medarbejderRepository = medarbejderRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateMedarbejderCommand request, CancellationToken cancellationToken)
    {
        var medarbejder = _mapper.Map<MedarbejderEntity>(request);

        try
        {
            UpdateMedarbejderCommandValidator updateCommandMedarbejderValidator = new();
            var result = await updateCommandMedarbejderValidator.ValidateAsync(request);
        }
        catch (DbUpdateConcurrencyException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        await _medarbejderRepository.UpdateAsync(medarbejder);

        return Unit.Value;
    }
}
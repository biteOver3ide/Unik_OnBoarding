using System.Data;
using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Projekt.Command.UpdateProjekt;

public class UpdateProjektHandler : IRequestHandler<UpdateProjektCommand>
{
    private readonly IMapper _mapper;
    private readonly IProjectRepository _projectRepository;

    public UpdateProjektHandler(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }

    // no return type
    async Task<Unit> IRequestHandler<UpdateProjektCommand, Unit>.Handle(UpdateProjektCommand request,
        CancellationToken cancellationToken)
    {
        var projekt = _mapper.Map<ProjektEntity>(request);

        try
        {
            UpdateCommandKProjektValidator updateCommandValidator = new();
            var result = await updateCommandValidator.ValidateAsync(request);
        }
        catch (DBConcurrencyException e)
        {
            Console.WriteLine(e.Message); // TODO  manage Concurrency excaption
            throw;
        }

        await _projectRepository.UpdateAsync(projekt);

        return Unit.Value;
    }
}
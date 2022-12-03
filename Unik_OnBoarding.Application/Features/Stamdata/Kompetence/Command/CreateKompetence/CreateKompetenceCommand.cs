using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kompetence.Command.CreateKompetence;

public class CreateKompetenceCommand : IRequest<Guid>
{
    public Guid KompetenceId { get; set; }
    public string KompetenceName { get; set; }
    public string Beskrivelse { get; set; }
}
using MediatR;

namespace Unik_OnBoarding.Application.Features.Kompetence.Command.UpdateKompetence;

public class UpdateKompetenceCommand : IRequest
{
    public Guid KompetenceId { get; set; }
    public string KompetenceName { get; set; }
    public string Beskrivelse { get; set; }
}
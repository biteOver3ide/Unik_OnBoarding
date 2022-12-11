using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Unik_OnBoarding.Application.Features.Projekt.Command.CreateProjekt;

public class CreateProjektCommand : IRequest<Guid>
{
    [Required] public string ProjektTitle { get; set; }

    public Guid KundeId { get; set; }
}
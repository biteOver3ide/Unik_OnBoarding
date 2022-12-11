using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Unik_OnBoarding.Application.Features.Projekt.Command.UpdateProjekt;

public class UpdateProjektCommand : IRequest
{
    [Key] public Guid ProjektId { get; set; }

    [Required] public string ProjektTitle { get; set; }

    public Guid KundeId { get; set; }
}
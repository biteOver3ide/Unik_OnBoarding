using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Application.Features.Projekt.Command.DeleteProjekt;

public class DeleteProjektCommand : IRequest
{
    [Required] public Guid ProjektId { get; set; }
}
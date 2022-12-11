using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Unik_OnBoarding.Application.Features.Kompetence.Command.DeleteKompetence;

public class DeleteKompetenceCommand : IRequest
{
    [Required] public Guid KompetenceId { get; set; }
}
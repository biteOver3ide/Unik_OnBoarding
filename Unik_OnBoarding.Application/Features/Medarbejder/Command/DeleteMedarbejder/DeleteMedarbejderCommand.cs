using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Command.DeleteMedarbejder;

public class DeleteMedarbejderCommand : IRequest
{
	[Required] public Guid MedarbejderId { get; set; }
}
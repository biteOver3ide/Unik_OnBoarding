using MediatR;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Command.DeleteMedarbejder;

public class DeleteMedarbejderCommand : IRequest
{
    public Guid MedarbejderId { get; set; }
}
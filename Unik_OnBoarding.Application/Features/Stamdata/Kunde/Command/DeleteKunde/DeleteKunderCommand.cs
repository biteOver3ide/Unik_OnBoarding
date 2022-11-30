using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.DeleteKunde;

public class DeleteKunderCommand : IRequest
{
    public Guid Kid { get; set; }
}
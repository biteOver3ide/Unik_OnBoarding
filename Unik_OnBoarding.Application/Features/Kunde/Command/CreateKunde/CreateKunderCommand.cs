using MediatR;

namespace Unik_OnBoarding.Application.Features.Kunde.Command.CreateKunde;

public class CreateKunderCommand : IRequest<Guid>
{
    public string Name { get; set; }

    public string Email { get; set; }

    public int Telefon { get; set; }

    public string Adresse { get; set; }
}
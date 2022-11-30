using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.CreateKunde;

public class CreateKunderCommand : IRequest<Guid>
{
    public Guid Kid { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public int Telefon { get; set; }

    public string Adresse { get; set; }
}
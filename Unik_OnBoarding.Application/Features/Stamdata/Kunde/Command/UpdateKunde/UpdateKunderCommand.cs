using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Kunde.Command.UpdateKunde;

public class UpdateKunderCommand : IRequest
{
    [Key] public Guid Kid { get; set; }

    public string Name { get; set; }

    [Required] public string Adresse { get; set; }

    [Required] [EmailAddress] public string Email { get; set; }

    public int Telefon { get; set; }
}
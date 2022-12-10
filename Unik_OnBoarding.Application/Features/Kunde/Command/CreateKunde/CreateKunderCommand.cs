using System.ComponentModel.DataAnnotations;
using MediatR;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Kunde.Command.CreateKunde;

public class CreateKunderCommand : IRequest<Guid>
{
    [Required] public string Fornavn { get; set; }

    [Required] public string Efternavn { get; set; }

    [Required] public string Firmanavn { get; set; }

    [Required] public int Cvr { get; set; }

    [Required] [EmailAddress] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    [Required] public string Adresse { get; set; }

    //public List<ProjektEntity>? Projekt { get; set; }
}
using System.ComponentModel.DataAnnotations;
using MediatR;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Command.CreateMedarbejder;

public class CreateMedarbejderCommand : IRequest<Guid>
{
    [Required] public string Fornavn { get; set; }

    [Required] public string Efternavn { get; set; }

    [Required] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    public Jobtitler Job { get; set; }

}
using MediatR;
using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Stamdata.Medarbejder.Command.CreateMedarbejder;

public class CreateMedarbejderCommand : IRequest<Guid>
{
    [Key] public Guid MedarbejderId { get; set; }

    [Required] public string Fornavn { get; set; }

    public string Efternavn { get; set; }

    [Required] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    public Jobtitler Job { get; set; }
}
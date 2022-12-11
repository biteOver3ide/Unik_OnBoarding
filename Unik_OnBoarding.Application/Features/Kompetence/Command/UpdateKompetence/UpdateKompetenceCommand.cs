using MediatR;
using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Kompetence.Command.UpdateKompetence;

public class UpdateKompetenceCommand : IRequest
{
    [Required] public Guid KompetenceId { get; set; }

    [Required] public Jobtitler Job { get; set; }

    [Required] public string Beskrivelse { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }
}
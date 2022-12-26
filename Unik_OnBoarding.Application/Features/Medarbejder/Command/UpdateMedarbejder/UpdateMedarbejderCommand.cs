using System.ComponentModel.DataAnnotations;
using MediatR;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Medarbejder.Command.UpdateMedarbejder;

public class UpdateMedarbejderCommand : IRequest
{
	[Required] public Guid MedarbejderId { get; set; }

    [Required] public string Fornavn { get; set; }

	[Required] public string Efternavn { get; set; }

    [Required] public string Email { get; set; }

    [Required] public string Telefon { get; set; }

    public string UserId { get; set; }

	public Jobtitler Job { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }
}
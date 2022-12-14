using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;

public class CreateBookingDto
{
	[Required] public Guid ProjektId { get; set; }

	[Required] public Guid OpgaveId { get; set; }

	[Required] public Guid MedarbejderId { get; set; }

	public Status Status { get; set; }

	[StringLength(30)]
	[MinLength(3, ErrorMessage = "{0} må ikke være korter end {1} bogstaver. ")]
	[Required(ErrorMessage = "indtast et gyldig {0}")]
	public string? Beskrivelse { get; set; }

	[Required(ErrorMessage = "Startdato er påkrævet")]
	[DataType(DataType.Date)]
	[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
	[DisplayName("Start dato")]
	public DateTime StartDate { get; set; } = DateTime.UtcNow;

	[Required(ErrorMessage = "Slutdato er påkrævet")]
	[DataType(DataType.Date)]
	[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
	[DisplayName("Slut dato")]
	public DateTime EndDate { get; set; }

	[Required] public int Duration { get; set; }
}
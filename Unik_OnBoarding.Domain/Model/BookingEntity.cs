using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unik_OnBoarding.Domain.DomainService;

namespace Unik_OnBoarding.Domain.Model;

public class BookingEntity
{
	private readonly IBookingDomainService _bookingDomainService;

	//for ef only
	internal BookingEntity()
	{
		
	}

	public BookingEntity(IBookingDomainService bookingDomainService)
	{
		_bookingDomainService = bookingDomainService;


		if (_bookingDomainService.BookingExsistsOnDate(StartDate.Date, EndDate.Date))
		{
			throw new ArgumentException("Dato er allerde booket");
		}
	}

	[Key] public Guid BookId { get; set; }

	public Guid ProjektId { get; set; }

	[ForeignKey("ProjektId")] public ProjektEntity Projekt { get; set; }

	public Guid OpgaveId { get; set; }

	[ForeignKey("OpgaveId")] public OpgaverEntity Opgave { get; set; }

	public Guid MedarbejderId { get; set; }

	[ForeignKey("MedarbejderId")] public MedarbejderEntity Medarbejder { get; set; }

	[Required(ErrorMessage = "Startdato er påkrævet")]
	[DataType(DataType.Date)]
	[DisplayName("Start dato")]
	public DateTime StartDate { get; set; } = DateTime.UtcNow;

	[Required(ErrorMessage = "Slutdato er påkrævet")]
	[DataType(DataType.Date)]
	[DisplayName("Slut dato")]
	public DateTime EndDate { get; set; }

	public int Duration { get; set; }

	public string? Beskrivelse { get; set; }

	[Column(TypeName = "nvarchar(24)")] public Status Status { get; set; } = Status.Aktiv;

	[Timestamp] public byte[] RowVersion { get; set; }

}
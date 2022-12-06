using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;

public class BookingUpdateDto
{
    public Guid BookingId { get; set; }
    public OpgaverEntity Opgave { get; set; }
    public ProjektEntity Projekt { get; set; }
    public MedarbejderEntity Medarbejder { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; }
    public byte[] RowVersion { get; set; }
}
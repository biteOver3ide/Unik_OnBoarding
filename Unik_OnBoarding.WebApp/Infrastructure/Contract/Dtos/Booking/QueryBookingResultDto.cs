using System.ComponentModel.DataAnnotations;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;

public class QueryBookingResultDto
{
    public Guid BookingId { get; set; }
    public Guid ProjectId { get; set; }
    public Guid OpgaveId { get; set; }
    public Guid MedarbejdeId { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; }
    [Timestamp] public byte[] RowVersion { get; set; }
    public string? Beskrivelse { get; set; }
}
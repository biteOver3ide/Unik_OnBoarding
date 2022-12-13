using MediatR;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Booking.Command.CreateBooking;

public class CreateBookingCommand : IRequest<Guid>
{
    public Guid BookingId { get; set; }
    public Guid OpgaveId { get; set; }
    public Guid ProjektId { get; set; }
    public Guid MedarbejderId { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; }
}
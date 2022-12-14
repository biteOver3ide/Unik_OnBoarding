using MediatR;

namespace Unik_OnBoarding.Application.Features.Booking.Command.CreateBooking;

public class CreateBookingCommand : IRequest<Guid>
{
    public Guid OpgaveId { get; set; }
    public Guid ProjektId { get; set; }
    public Guid MedarbejderId { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; }
    public int Duration { get; set; }
}
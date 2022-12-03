using MediatR;

namespace Unik_OnBoarding.Application.Features.Stamdata.Booking.Command.DeleteBooking;

public class DeleteBookingCommand : IRequest
{
    public Guid BookingId { get; set; }
}
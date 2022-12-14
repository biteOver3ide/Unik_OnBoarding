using MediatR;

namespace Unik_OnBoarding.Application.Features.Booking.Command.DeleteBooking;

public class DeleteBookingCommand : IRequest
{
    public Guid BookId { get; set; }
}
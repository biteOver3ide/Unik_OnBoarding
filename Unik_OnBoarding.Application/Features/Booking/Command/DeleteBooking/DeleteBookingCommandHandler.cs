using MediatR;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Booking.Command.DeleteBooking;

public class DeleteBookingCommandHandler : IRequestHandler<DeleteBookingCommand>
{
    private readonly IBookingRepository _bookingRepository;

    public DeleteBookingCommandHandler(IBookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public async Task<Unit> Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
    {
        var bookingFromDb = await _bookingRepository.GetBookingByIdAsync(request.BookingId);

        await _bookingRepository.DeleteAsync(bookingFromDb);
        return Unit.Value;
    }
}
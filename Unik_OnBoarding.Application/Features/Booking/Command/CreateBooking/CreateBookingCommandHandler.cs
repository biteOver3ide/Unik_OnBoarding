using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Booking.Command.CreateBooking;

public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, Guid>
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IMapper _mapper;

    public CreateBookingCommandHandler(IBookingRepository bookingRepository, IMapper mapper)
    {
        _bookingRepository = bookingRepository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
    {
        var booking = _mapper.Map<BookingEntity>(request);

        CreateBookingValidator validator = new();
        var result = await validator.ValidateAsync(request);

        if (result.Errors.Any()) throw new Exception("Forkert indtasting");

        booking = await _bookingRepository.AddAsync(booking);
        return booking.BookingId;
    }
}
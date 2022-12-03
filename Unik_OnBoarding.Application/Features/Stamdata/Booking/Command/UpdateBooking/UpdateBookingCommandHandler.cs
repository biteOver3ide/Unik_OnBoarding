using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Features.Stamdata.Booking.Command.UpdateBooking;

public class UpdateBookingCommandHandler : IRequestHandler<UpdateBookingCommand>
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IMapper _mapper;

    public UpdateBookingCommandHandler(IBookingRepository bookingRepository, IMapper mapper)
    {
        _bookingRepository = bookingRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
    {
        var booking = _mapper.Map<BookingEntity>(request);

        try
        {
            UpdateBookingCommandValidator updateBookingCommandValidator = new();
            var result = await updateBookingCommandValidator.ValidateAsync(request);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        await _bookingRepository.UpdateAsync(booking);

        return Unit.Value;
    }
}
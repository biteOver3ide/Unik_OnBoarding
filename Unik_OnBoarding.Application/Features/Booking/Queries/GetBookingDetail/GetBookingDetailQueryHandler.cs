using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Booking.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Booking.Queries.GetBookingDetail;

public class GetBookingDetailQueryHandler : IRequestHandler<GetBookingDetailQuery, BookingDto>
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IMapper _mapper;

    public GetBookingDetailQueryHandler(IBookingRepository bookingRepository, IMapper mapper)
    {
        _bookingRepository = bookingRepository;
        _mapper = mapper;
    }

    public async Task<BookingDto> Handle(GetBookingDetailQuery request, CancellationToken cancellationToken)
    {
        var bookingFromDb = await _bookingRepository.GetBookingByIdAsync(request.BookingId);
        return _mapper.Map<BookingDto>(bookingFromDb);
    }
}
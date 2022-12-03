using AutoMapper;
using MediatR;
using Unik_OnBoarding.Application.Implementation.Booking.dto;
using Unik_OnBoarding.Application.Interfaceses;

namespace Unik_OnBoarding.Application.Features.Stamdata.Booking.Queries.GetBookingList;

public class GetBookingListQueryHandler : IRequestHandler<GetBookingListQuery, List<BookingDto>>
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IMapper _mapper;

    public GetBookingListQueryHandler(IBookingRepository bookingRepository, IMapper mapper)
    {
        _bookingRepository = bookingRepository;
        _mapper = mapper;
    }

    public async Task<List<BookingDto>> Handle(GetBookingListQuery request, CancellationToken cancellationToken)
    {
        var bookingFromDb = await _bookingRepository.GetAllBookingAsync();
        return _mapper.Map<List<BookingDto>>(bookingFromDb);
    }
}
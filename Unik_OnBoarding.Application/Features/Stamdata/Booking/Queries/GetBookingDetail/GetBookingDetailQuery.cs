using MediatR;
using Unik_OnBoarding.Application.Implementation.Booking.dto;

namespace Unik_OnBoarding.Application.Features.Stamdata.Booking.Queries.GetBookingDetail;

public class GetBookingDetailQuery :IRequest<BookingDto>
{
    public Guid BookingId { get; set; }
}
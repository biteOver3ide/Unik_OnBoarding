using MediatR;
using Unik_OnBoarding.Application.Implementation.Booking.dto;

namespace Unik_OnBoarding.Application.Features.Booking.Queries.GetBookingDetail;

public class GetBookingDetailQuery :IRequest<BookingDto>
{
    public Guid BookingId { get; set; }
}
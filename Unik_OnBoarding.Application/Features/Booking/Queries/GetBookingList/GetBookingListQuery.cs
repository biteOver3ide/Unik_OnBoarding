using MediatR;
using Unik_OnBoarding.Application.Implementation.Booking.dto;

namespace Unik_OnBoarding.Application.Features.Booking.Queries.GetBookingList;

public class GetBookingListQuery : IRequest<List<BookingDto>>
{
}
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IBookingService
{
    Task Create(BookingCreateDto dto);
    Task Edit(BookingUpdateDto bookingUpdateViewModel);
    Task<BookingQueryResultDto?> Get(Guid id);
    Task<IEnumerable<BookingQueryResultDto>?> GetAll();
}


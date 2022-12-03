using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Interfaceses;

public interface IBookingRepository : IAsyncRepository<BookingEntity>
{
    Task<List<BookingEntity>> GetAllBookingAsync();
    Task<BookingEntity> GetBookingByIdAsync(Guid bookingId);
}
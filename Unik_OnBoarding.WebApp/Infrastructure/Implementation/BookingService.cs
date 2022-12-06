using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Infrastructure.Implementation;

public class BookingService : IBookingService
{
    private readonly HttpClient _httpClient;

    public BookingService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task Create(BookingCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Edit(BookingUpdateDto bookingUpdateViewModel)
    {
        throw new NotImplementedException();
    }

    public Task<BookingQueryResultDto?> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BookingQueryResultDto>?> GetAll()
    {
        throw new NotImplementedException();
    }
}
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

    async Task IBookingService.Create(BookingCreateDto dto)
    {
        {
            var response = await _httpClient.PostAsJsonAsync("api/Booking", dto);

            if (response.IsSuccessStatusCode)
                return;

            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }
    }

    Task IBookingService.Edit(BookingUpdateDto bookingUpdateViewModel)
    {
        throw new NotImplementedException();
    }

    Task<BookingQueryResultDto?> IBookingService.Get(Guid id)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<BookingQueryResultDto>?> IBookingService.GetAll()
    {
        throw new NotImplementedException();
    }



}
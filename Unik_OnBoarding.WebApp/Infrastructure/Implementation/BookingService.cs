using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Booking.dto;
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

    async Task IBookingService.Delete(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Booking/{id}");
    }

    async Task<QueryBookingResultDto?> IBookingService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<QueryBookingResultDto>($"api/Booking/{id}");
    }

    async Task<IEnumerable<QueryBookingResultDto>?> IBookingService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<QueryBookingResultDto>>("api/Booking");
    }

    async Task IBookingService.Create(CreateBookingDto dto)
    {
        {
            var response = await _httpClient.PostAsJsonAsync("api/Booking", dto);

            if (response.IsSuccessStatusCode)
                return;

            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }
    }

    async Task IBookingService.Edit( UpdateBookingDto updateBookingViewModel )
    {
        var response =
            await _httpClient.PutAsJsonAsync("api/Booking", updateBookingViewModel);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }
}
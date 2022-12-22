using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Infrastructure.Implementation;

public class KundeService : IKundeService
{
    private readonly HttpClient _httpClient;

    public KundeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    async Task IKundeService.Create(CreateKundeRequestDto createKundeRequestDto)
    {
        var response =
            await _httpClient.PostAsJsonAsync("api/Kunde", createKundeRequestDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task IKundeService.Delete(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Kunde/{id}");
    }

    async Task IKundeService.Edit( UpdateKundeDto queryKundeUpdateDto )
    {
        var response =
            await _httpClient.PutAsJsonAsync("api/Kunde", queryKundeUpdateDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task<QueryKundeResultDto?> IKundeService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<QueryKundeResultDto>($"api/Kunde/{id}");
    }

    async Task<IEnumerable<QueryKundeResultDto>?> IKundeService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<QueryKundeResultDto>>("api/Kunde");
    }

    async Task<IEnumerable<KundeDto>> IKundeService.GetAllDataAsync(Expression<Func<KundeDto, bool>>? filter)
    {
        return await _httpClient.GetFromJsonAsync<List<KundeDto>>("api/Kunde");
    }
}
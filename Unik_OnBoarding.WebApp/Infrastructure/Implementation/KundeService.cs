using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;
using KundeCreateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde.KundeCreateRequestDto;

namespace Unik_OnBoarding.WebApp.Infrastructure.Implementation;

public class KundeService : IKundeService
{
    private readonly HttpClient _httpClient;

    public KundeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    async Task IKundeService.Create(KundeCreateDto kundeCreateRequestDto)
    {
        var response =
            await _httpClient.PostAsJsonAsync("api/Kunde", kundeCreateRequestDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task IKundeService.Delete(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Kunde/{id}");
    }

    async Task IKundeService.Edit(KundeQueryResultDto kundeUpdateDto)
    {
        var response =
            await _httpClient.PutAsJsonAsync("api/Kunde", kundeUpdateDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task<KundeQueryResultDto?> IKundeService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<KundeQueryResultDto>($"api/Kunde/{id}");
    }

    async Task<IEnumerable<KundeQueryResultDto>?> IKundeService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<KundeQueryResultDto>>("api/Kunde");
    }

    async Task<IEnumerable<KundeDto>> IKundeService.GetAllDataAsync(Expression<Func<KundeDto, bool>>? filter)
    {
        throw new NotImplementedException();
    }

    async Task<KundeDto> IKundeService.GetByIdAsync(Guid Id, Expression<Func<KundeDto, bool>>? filter)
    {
        throw new NotImplementedException();
    }
}
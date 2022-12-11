using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Kompetencer.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Infrastructure.Implementation;

public class KompetenceService : IKompetenceService
{
    private readonly HttpClient _httpClient;

    public KompetenceService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    async Task IKompetenceService.Create(CreateKompetenceDto dto)
    {
        var response =
            await _httpClient.PostAsJsonAsync("api/Kompetence", dto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task IKompetenceService.Delete(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Kompetence/{id}");
    }

    async Task IKompetenceService.Edit(QueryKompetenceResultDto kompetenceUpdateDto)
    {
        var response =
            await _httpClient.PutAsJsonAsync("api/Kompetence", kompetenceUpdateDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task<QueryKompetenceResultDto?> IKompetenceService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<QueryKompetenceResultDto>($"api/Kompetence/{id}");
    }

    async Task<IEnumerable<QueryKompetenceResultDto>?> IKompetenceService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<QueryKompetenceResultDto>>("api/Kompetence");
    }

    async Task<IEnumerable<KompetenceDto>> IKompetenceService.GetAllDataAsync(
        Expression<Func<KompetenceDto, bool>>? filter)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<KompetenceDto>>("api/Kompetence");
    }
}
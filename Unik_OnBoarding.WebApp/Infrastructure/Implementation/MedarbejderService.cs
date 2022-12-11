using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Infrastructure.Implementation;

public class MedarbejderService : IMedarbejderService
{
    private readonly HttpClient _httpClient;

    public MedarbejderService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    async Task IMedarbejderService.Create(CreateMedarbejderRequestDto createMedarbejderCreatedto)
    {
        var response =
            await _httpClient.PostAsJsonAsync("api/Medarbejder", createMedarbejderCreatedto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task IMedarbejderService.Delete(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Medarbejder/{id}");
    }

    async Task IMedarbejderService.Edit(QueryMedarbejderResultDto queryMedarbejderUpdateDto)
    {
        var response =
            await _httpClient.PutAsJsonAsync("api/Medarbejder", queryMedarbejderUpdateDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task<QueryMedarbejderResultDto?> IMedarbejderService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<QueryMedarbejderResultDto>($"api/Medarbejder/{id}");
    }

    async Task<IEnumerable<QueryMedarbejderResultDto>?> IMedarbejderService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<QueryMedarbejderResultDto>>("api/Medarbejder");
    }

    async Task<IEnumerable<MedarbejderDto>> IMedarbejderService.GetAllDataAsync(
        Expression<Func<MedarbejderDto, bool>>? filter)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<MedarbejderDto>>("api/Medarbejder");
    }
}
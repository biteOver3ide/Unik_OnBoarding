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

    async Task IMedarbejderService.Create(MedarbejderCreateRequestDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Medarbejder", dto);

        //if (response.IsSuccessStatusCode) return;

        //var message = await response.Content.ReadAsStringAsync();
        //throw new Exception(message);
    }

    async Task IMedarbejderService.Edit(MedarbejderUpdateRequestDto medarbejderUpdateDto)
    {
        var response = await _httpClient.PutAsJsonAsync("api/Medarbejder", medarbejderUpdateDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task<MedarbejderQueryResultDto?> IMedarbejderService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<MedarbejderQueryResultDto>($"api/Medarbejder/{id}");
    }

    async Task<IEnumerable<MedarbejderQueryResultDto>?> IMedarbejderService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<MedarbejderQueryResultDto>>("api/Medarbejder");
    }

    async Task<IEnumerable<MedarbejderDto>> IMedarbejderService.GetAllDataAsync(
        Expression<Func<MedarbejderDto, bool>>? filter)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<MedarbejderDto>>("api/Medarbejder");
    }
}
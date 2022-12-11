using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Infrastructure.Implementation;

public class ProjektService : IProjektService
{
    private readonly HttpClient _httpClient;

    public ProjektService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    async Task IProjektService.Create(CreateProjektDto dto)
    {
        var response =
            await _httpClient.PostAsJsonAsync("api/Projekt", dto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task IProjektService.Delete(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Projekt/{id}");
    }

    async Task IProjektService.Edit(UpdateProjektDto updateProjektDto)
    {
        var response =
            await _httpClient.PutAsJsonAsync("api/Projekt", updateProjektDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task<QueryProjektResultDto?> IProjektService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<QueryProjektResultDto>($"api/Projekt/{id}");
    }

    async Task<IEnumerable<QueryProjektResultDto>?> IProjektService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<QueryProjektResultDto>>("api/Projekt");
    }

    async Task<IEnumerable<ProjektDto>> IProjektService.GetAllDataAsync(Expression<Func<ProjektDto, bool>>? filter)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<ProjektDto>>("api/Projekt");
    }
}
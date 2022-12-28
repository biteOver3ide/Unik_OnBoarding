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

    async Task IProjektService.Create(CreateProjektRequestDto requestDto)
    {
        var response =
            await _httpClient.PostAsJsonAsync("api/Projekt", requestDto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task IProjektService.Delete(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Projekt/{id}");
    }

    async Task IProjektService.Edit(QueryProjektResultDto updateProjektDto)
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
}
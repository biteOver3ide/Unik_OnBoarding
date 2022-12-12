using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

namespace Unik_OnBoarding.WebApp.Infrastructure.Implementation;

public class OpgaverService : IOpgaverService
{
    private readonly HttpClient _httpClient;

    public OpgaverService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    async Task IOpgaverService.Create(CreateOpgaverDto dto)
    {
        var response =
            await _httpClient.PostAsJsonAsync("api/Opgaver", dto);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task IOpgaverService.Delete(Guid id)
    {
        await _httpClient.DeleteAsync($"api/Opgaver/{id}");
    }

    async Task IOpgaverService.Edit(QueryOpgaverResultDto opgaverResult)
    {
        var response =
            await _httpClient.PutAsJsonAsync("api/Opgaver", opgaverResult);

        if (response.IsSuccessStatusCode) return;

        var message = await response.Content.ReadAsStringAsync();
        throw new Exception(message);
    }

    async Task<QueryOpgaverResultDto?> IOpgaverService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<QueryOpgaverResultDto>($"api/Opgaver/{id}");
    }

   public async Task<IEnumerable<QueryOpgaverResultDto>?> GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<QueryOpgaverResultDto>>("api/Opgaver");
    }

    async Task<IEnumerable<OpgaverDto>> IOpgaverService.GetAllDataAsync(Expression<Func<OpgaverDto, bool>>? filter)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<OpgaverDto>>("api/Opgaver");
    }
}
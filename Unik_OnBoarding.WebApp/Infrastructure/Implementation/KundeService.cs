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

    public async Task Create(KundeCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Edit(KundeUpdateDto kundeUpdateViewModel)
    {
        throw new NotImplementedException();
    }

    public async Task<KundeQueryResultDto?> Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<KundeQueryResultDto>($"api/Kunde/{id}");
    }

    public async Task<IEnumerable<KundeQueryResultDto>?> GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<KundeQueryResultDto>>("api/Kunde");
    }
    //https://localhost:7241/api/GetAllKunder
}
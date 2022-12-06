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

    public Task Create(ProjektCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Edit(ProjektUpdateDto projektUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task<ProjektQueryResultDto?> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProjektQueryResultDto>?> GetAll()
    {
        throw new NotImplementedException();
    }
}
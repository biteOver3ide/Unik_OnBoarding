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

    public Task Create(KompetenceCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Edit(KompetenceUpdateDto kompetenceUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task<KompetenceQueryResultDto?> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<KompetenceQueryResultDto>?> GetAll()
    {
        throw new NotImplementedException();
    }
}
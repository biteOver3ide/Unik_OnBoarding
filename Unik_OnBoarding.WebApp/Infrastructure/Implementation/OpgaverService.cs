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

    public Task Create(OpgaverCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Edit(OpgaverUpdateDto medarbejderUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task<OpgaverQueryResultDto?> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OpgaverQueryResultDto>?> GetAll()
    {
        throw new NotImplementedException();
    }
}
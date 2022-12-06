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

    public Task Create(MedarbejderCreateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task Edit(MedarbejderUpdateDto medarbejderUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task<MedarbejderQueryResultDto?> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MedarbejderQueryResultDto>?> GetAll()
    {
        throw new NotImplementedException();
    }
}
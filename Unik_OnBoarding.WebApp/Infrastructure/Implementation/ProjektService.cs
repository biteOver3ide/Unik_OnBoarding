using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;
using ProjektCreateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt.ProjektCreateDto;
using ProjektUpdateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt.ProjektUpdateDto;

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

    public async Task<IEnumerable<ProjektDto>> GetAllDataAsync(Expression<Func<ProjektDto, bool>>? filter = null)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<ProjektDto>>($"api/Projekt");
    }
}
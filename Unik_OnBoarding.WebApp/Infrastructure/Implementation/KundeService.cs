using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;
using KundeCreateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde.KundeCreateDto;
using KundeUpdateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde.KundeUpdateDto;

namespace Unik_OnBoarding.WebApp.Infrastructure.Implementation;

public class KundeService : IKundeService
{
    private readonly HttpClient _httpClient;

    public KundeService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<IEnumerable<KundeDto>> GetAllDataAsync(Expression<Func<KundeDto, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    public Task<KundeDto> GetByIdAsync(Guid Id, Expression<Func<KundeDto, bool>>? filter = null)
    {
        throw new NotImplementedException();
    }

    async Task IKundeService.Create(KundeCreateDto dto)
    {
        await _httpClient.PostAsJsonAsync("api/Kunde", dto);
    }

    async Task IKundeService.Edit(KundeUpdateDto kundeUpdateViewModel)
    {
        await _httpClient.PutAsJsonAsync("api/Kunde", kundeUpdateViewModel);
    }

    async Task<KundeQueryResultDto?> IKundeService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<KundeQueryResultDto>($"api/Kunde/{id}");
    }

    async Task<IEnumerable<KundeQueryResultDto>?> IKundeService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<KundeQueryResultDto>>("api/Kunde");
    }
}
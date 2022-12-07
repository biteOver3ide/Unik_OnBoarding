using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
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

    async Task IMedarbejderService.Create(MedarbejderCreateRequestDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Medarbejder", dto);
    }

    async Task IMedarbejderService.CreateAsync(MedarbejderCreateRequestDto entity)
    {
        var response = await _httpClient.PostAsJsonAsync("api/Medarbejder", entity);

        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Result: {0}", result);
        }
        else
        {
            Console.WriteLine("The request failed with status code: {0}", response.StatusCode);

            // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
            Console.WriteLine(response.Headers.ToString());

            var responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
        }
    }

    async Task IMedarbejderService.Edit(MedarbejderUpdateRequestDto medarbejderUpdateDto)
    {
        await _httpClient.PutAsJsonAsync("api/Medarbejder", medarbejderUpdateDto);
    }

    async Task<MedarbejderQueryResultDto?> IMedarbejderService.Get(Guid id)
    {
        return await _httpClient.GetFromJsonAsync<MedarbejderQueryResultDto>($"api/Medarbejder/{id}");
    }

    async Task<IEnumerable<MedarbejderQueryResultDto>?> IMedarbejderService.GetAll()
    {
        return await _httpClient.GetFromJsonAsync<List<MedarbejderQueryResultDto>>("api/Medarbejder");
    }

    async Task<IEnumerable<MedarbejderDto>> IMedarbejderService.GetAllDataAsync(
        Expression<Func<MedarbejderDto, bool>>? filter)
    {
        return await _httpClient.GetFromJsonAsync<IEnumerable<MedarbejderDto>>("api/Medarbejder");
    }
}
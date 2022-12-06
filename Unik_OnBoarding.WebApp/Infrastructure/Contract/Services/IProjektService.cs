using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IProjektService
{
    Task Create(ProjektCreateDto dto);
    Task Edit(ProjektUpdateDto projektUpdateDto);
    Task<ProjektQueryResultDto?> Get(Guid id);
    Task<IEnumerable<ProjektQueryResultDto>?> GetAll();
}
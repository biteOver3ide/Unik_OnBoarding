using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IKundeService
{
    Task Create(KundeCreateDto dto);
    Task Edit(KundeUpdateDto kundeUpdateViewModel);
    Task<KundeQueryResultDto?> Get(Guid id);
    Task<IEnumerable<KundeQueryResultDto>?> GetAll();
}
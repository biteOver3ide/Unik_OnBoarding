using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dto;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract;

public interface IKundeService
{
    Task Create(KundeCreateDto dto);
    Task Edit(KundeUpdateDto kundeUpdateViewModel);
    Task<KundeQueryResultDto?> Get(Guid id);
    Task<IEnumerable<KundeQueryResultDto>?> GetAll();
}
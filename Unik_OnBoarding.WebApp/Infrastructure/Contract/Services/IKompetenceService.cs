using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IKompetenceService
{
    Task Create(KompetenceCreateDto dto);
    Task Edit(KompetenceUpdateDto kompetenceUpdateDto);
    Task<KompetenceQueryResultDto?> Get(Guid id);
    Task<IEnumerable<KompetenceQueryResultDto>?> GetAll();
}
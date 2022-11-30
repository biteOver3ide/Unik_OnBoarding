using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Interfaceses;

public interface IProjectRepository : IAsyncRepository<ProjektEntity>
{
    Task<List<ProjektEntity>> GetAllProjektAsync(bool includeKunde);
    Task<ProjektEntity> GetProjektByIdAsync(Guid projektId);
}
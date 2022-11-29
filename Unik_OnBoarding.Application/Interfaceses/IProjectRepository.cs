using Unik_OnBoarding.Domain;

namespace Unik_OnBoarding.Application.Interfaceses;

public interface IProjectRepository : IAsyncRepository<Projekt>
{
    Task<List<Projekt>> GetAllProjektAsync(bool includeKunde);
    Task<Projekt> GetProjektByIdAsync(Guid projektId);
}
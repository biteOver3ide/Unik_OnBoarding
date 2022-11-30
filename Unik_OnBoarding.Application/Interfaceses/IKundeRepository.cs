using Unik_OnBoarding.Domain;

namespace Unik_OnBoarding.Application.Interfaceses;

public interface IKundeRepository : IAsyncRepository<Kunde>
{
    Task<List<Kunde>> GetAllKundeAsync(bool includeProjekt);
    Task<Kunde> GetKundeByIdAsync(Guid kundeId);
}
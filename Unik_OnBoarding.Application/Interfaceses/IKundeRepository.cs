using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Interfaceses;

public interface IKundeRepository : IAsyncRepository<KundeEntity>
{
    Task<List<KundeEntity>> GetAllKundeAsync(bool includeProjekt);
    Task<KundeEntity> GetKundeByIdAsync(Guid kundeId);
}
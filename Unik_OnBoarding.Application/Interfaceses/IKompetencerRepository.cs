using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Interfaceses;

public interface IKompetencerRepository : IAsyncRepository<KompetenceEntity>
{
    Task<List<KompetenceEntity>> GetAllKompetencerAsync();
    Task<KompetenceEntity> GetKompetencerByIdAsync(Guid kompetencerId);
}

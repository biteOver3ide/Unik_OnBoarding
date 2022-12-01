using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Interfaceses;

public interface IMedarbejderRepository : IAsyncRepository<MedarbejderEntity>
{
    Task<List<MedarbejderEntity>> GetAllMedarbejderAsync(bool includeProjekt);
    Task<MedarbejderEntity> GetMedarbejderByIdAsync(Guid medarbejderId);
}
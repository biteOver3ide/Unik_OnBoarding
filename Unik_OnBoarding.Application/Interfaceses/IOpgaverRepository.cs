using Unik_OnBoarding.Domain.Model;

namespace Unik_OnBoarding.Application.Interfaceses;

public interface IOpgaverRepository : IAsyncRepository<OpgaverEntity>
{
    Task<List<OpgaverEntity>> GetAllOpgaverAsync();
    Task<OpgaverEntity> GetOpgaverByIdAsync(Guid opgaverId);
}
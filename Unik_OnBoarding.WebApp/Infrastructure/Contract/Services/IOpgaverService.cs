using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IOpgaverService
{
    Task Create(OpgaverCreateDto dto);
    Task Edit(OpgaverUpdateDto medarbejderUpdateDto);
    Task<OpgaverQueryResultDto?> Get(Guid id);
    Task<IEnumerable<OpgaverQueryResultDto>?> GetAll();
}
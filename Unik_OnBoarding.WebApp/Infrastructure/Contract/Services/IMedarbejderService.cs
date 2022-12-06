using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IMedarbejderService
{
    Task Create(MedarbejderCreateDto dto);
    Task Edit(MedarbejderUpdateDto medarbejderUpdateDto);
    Task<MedarbejderQueryResultDto?> Get(Guid id);
    Task<IEnumerable<MedarbejderQueryResultDto>?> GetAll();
}
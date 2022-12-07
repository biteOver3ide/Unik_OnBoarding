using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IMedarbejderService
{
    Task Create(MedarbejderCreateRequestDto dto);
    Task Edit(MedarbejderUpdateRequestDto medarbejderUpdateDto);
    Task<MedarbejderQueryResultDto?> Get(Guid id);
    Task<IEnumerable<MedarbejderQueryResultDto>?> GetAll();
    Task CreateAsync(MedarbejderCreateRequestDto entity);
    Task<IEnumerable<MedarbejderDto>> GetAllDataAsync(Expression<Func<MedarbejderDto, bool>>? filter = null);
}
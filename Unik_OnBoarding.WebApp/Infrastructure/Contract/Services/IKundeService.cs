using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using KundeCreateRequestDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde.KundeCreateRequestDto;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IKundeService
{
    Task<IEnumerable<KundeDto>> GetAllDataAsync(Expression<Func<KundeDto, bool>>? filter = null);
    Task<KundeDto> GetByIdAsync(Guid Id, Expression<Func<KundeDto, bool>>? filter = null);
    Task Create(KundeCreateRequestDto kundeCreateRequestDto);
    Task Edit(KundeQueryResultDto kundeUpdateDto);
    Task Delete(Guid id);
    Task<KundeQueryResultDto?> Get(Guid id);
    Task<IEnumerable<KundeQueryResultDto>?> GetAll();
}
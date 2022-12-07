using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;
using KundeCreateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde.KundeCreateDto;
using KundeUpdateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde.KundeUpdateDto;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IKundeService
{
    Task<IEnumerable<KundeDto>> GetAllDataAsync(Expression<Func<KundeDto, bool>>? filter = null);
    Task<KundeDto> GetByIdAsync(Guid Id, Expression<Func<KundeDto, bool>>? filter = null);
    Task Create(KundeCreateDto dto);
    Task Edit(KundeUpdateDto kundeUpdateViewModel);
    Task<KundeQueryResultDto?> Get(Guid id);
    Task<IEnumerable<KundeQueryResultDto>?> GetAll();
}
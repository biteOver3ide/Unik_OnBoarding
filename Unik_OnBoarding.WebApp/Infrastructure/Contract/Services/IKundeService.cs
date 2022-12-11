using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Kunde.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kunde;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IKundeService
{
    Task Create(CreateKundeRequestDto createKundeRequestDto);
    Task Edit(QueryKundeResultDto queryKundeUpdateDto);
    Task Delete(Guid id);
    Task<QueryKundeResultDto?> Get(Guid id);
    Task<IEnumerable<QueryKundeResultDto>?> GetAll();
    Task<IEnumerable<KundeDto>> GetAllDataAsync(Expression<Func<KundeDto, bool>>? filter = null);
}
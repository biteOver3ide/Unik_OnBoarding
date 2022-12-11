using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IOpgaverService
{
    Task Create(CreateOpgaverDto dto);
    Task Edit(QueryOpgaverResultDto medarbejderUpdateDto);
    Task Delete(Guid id);
    Task<QueryOpgaverResultDto?> Get(Guid id);
    Task<IEnumerable<QueryOpgaverResultDto>?> GetAll();
    Task<IEnumerable<OpgaverDto>> GetAllDataAsync(Expression<Func<OpgaverDto, bool>>? filter = null);
}
using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Kompetencer.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Kompetence;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IKompetenceService
{
    Task Create(CreateKompetenceDto dto);
    Task Edit(QueryKompetenceResultDto kompetenceUpdateDto);
    Task Delete(Guid id);
    Task<QueryKompetenceResultDto?> Get(Guid id);
    Task<IEnumerable<QueryKompetenceResultDto>?> GetAll();
}
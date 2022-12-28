using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Medarbejder.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Medarbejder;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IMedarbejderService
{
    Task Create(CreateMedarbejderRequestDto createMedarbejderCreatedto);
    Task Edit(QueryMedarbejderResultDto queryMedarbejderUpdateDto);
    Task Delete(Guid id);
    Task<QueryMedarbejderResultDto?> Get(Guid id);
    Task<IEnumerable<QueryMedarbejderResultDto>?> GetAll();
    Task<IEnumerable<QueryMedarbejderResultDto>?> GetAllUser(string identityName);
}
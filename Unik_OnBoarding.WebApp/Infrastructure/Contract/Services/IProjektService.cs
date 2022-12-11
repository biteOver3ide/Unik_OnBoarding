using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IProjektService
{
    Task Create(CreateProjektDto dto);
    Task Edit(UpdateProjektDto updateProjektDto);
    Task Delete(Guid id);
    Task<QueryProjektResultDto?> Get(Guid id);
    Task<IEnumerable<QueryProjektResultDto>?> GetAll();
    Task<IEnumerable<ProjektDto>> GetAllDataAsync(Expression<Func<ProjektDto, bool>>? filter = null);
}
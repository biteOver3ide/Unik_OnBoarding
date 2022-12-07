using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Projekt.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt;
using ProjektCreateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt.ProjektCreateDto;
using ProjektUpdateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Projekt.ProjektUpdateDto;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IProjektService
{
    Task Create(ProjektCreateDto dto);
    Task Edit(ProjektUpdateDto projektUpdateDto);
    Task<ProjektQueryResultDto?> Get(Guid id);
    Task<IEnumerable<ProjektQueryResultDto>?> GetAll();
    Task<IEnumerable<ProjektDto>> GetAllDataAsync(Expression<Func<ProjektDto, bool>>? filter = null);
}
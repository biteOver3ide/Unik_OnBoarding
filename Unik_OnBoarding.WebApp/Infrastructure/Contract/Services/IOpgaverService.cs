using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Opgaver.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver;
using OpgaverCreateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver.OpgaverCreateDto;
using OpgaverUpdateDto = Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Opgaver.OpgaverUpdateDto;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IOpgaverService
{
    Task Create(OpgaverCreateDto dto);
    Task Edit(OpgaverUpdateDto medarbejderUpdateDto);
    Task<OpgaverQueryResultDto?> Get(Guid id);
    Task<IEnumerable<OpgaverQueryResultDto>?> GetAll();
    Task<IEnumerable<OpgaverDto>> GetAllDataAsync(Expression<Func<OpgaverDto, bool>>? filter = null);
}
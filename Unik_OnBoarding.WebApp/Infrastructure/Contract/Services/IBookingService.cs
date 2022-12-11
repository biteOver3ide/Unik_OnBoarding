using System.Linq.Expressions;
using Unik_OnBoarding.Application.Implementation.Booking.dto;
using Unik_OnBoarding.WebApp.Infrastructure.Contract.Dtos.Booking;

namespace Unik_OnBoarding.WebApp.Infrastructure.Contract.Services;

public interface IBookingService
{
    Task Create(CreateBookingDto dto);
    Task Edit(QueryBookingResultDto updateBookingViewModel);
    Task Delete(Guid id);
    Task<QueryBookingResultDto?> Get(Guid id);
    Task<IEnumerable<QueryBookingResultDto>?> GetAll();
    Task<IEnumerable<BookingDto>> GetAllDataAsync(Expression<Func<BookingDto, bool>>? filter = null);
}


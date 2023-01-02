using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Domain.DomainService;
using Unik_OnBoarding.Persistance.DatabaseContext;

namespace Unik_OnBoarding.Persistance.DomainService;

public class BookingDomainService : IBookingDomainService
{
	private readonly AppDbContext _db;

	public BookingDomainService(AppDbContext db)
	{
		_db = db;
	}


	bool IBookingDomainService.BookingExsistsOnDate(DateTime startDate, DateTime endDate)
	{
		return _db.Bookinger.AsNoTracking().ToList().Any(
			a => a.StartDate.Date == startDate.Date && a.EndDate.Date == endDate.Date);
	}
}
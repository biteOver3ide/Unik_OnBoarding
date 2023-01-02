namespace Unik_OnBoarding.Domain.DomainService;

public interface IBookingDomainService
{
	bool BookingExsistsOnDate(DateTime startDate, DateTime endDate);
}
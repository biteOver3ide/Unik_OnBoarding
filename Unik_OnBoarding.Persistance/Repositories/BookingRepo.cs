using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class BookingRepo : BaseRepo<BookingEntity>, IBookingRepository
{
    public BookingRepo(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<BookingEntity>> GetAllBookingAsync()
    {
        var bookinglist = new List<BookingEntity>();
        bookinglist = await _appDbContext.Bookinger.ToListAsync();
        return bookinglist;
    }

    public async Task<BookingEntity> GetBookingByIdAsync(Guid bookingId)
    {
        var booking = new BookingEntity();
        booking = await _appDbContext.Bookinger.Where(b => b.BookId == bookingId).FirstOrDefaultAsync();
        return booking;
    }
}
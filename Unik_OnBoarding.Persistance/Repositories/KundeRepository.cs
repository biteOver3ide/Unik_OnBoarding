using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class KundeRepository : BaseRepository<Kunde>, IKundeRepository
{
    public KundeRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<Kunde>> GetAllKundeAsync(bool includeProjekt)
    {
        var kundelist = new List<Kunde>();
        kundelist = await _appDbContext.Kunder.ToListAsync();
        return kundelist;
    }

    public async Task<Kunde> GetKundeByIdAsync(Guid kundeId)
    {
        var kunder = new Kunde();
        kunder = await _appDbContext.Kunder.Where(k => k.Kid == kundeId).FirstOrDefaultAsync();
        return kunder;
    }
}
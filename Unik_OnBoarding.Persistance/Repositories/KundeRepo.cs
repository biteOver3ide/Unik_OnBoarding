using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DatabaseContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class KundeRepo : BaseRepo<KundeEntity>, IKundeRepository
{
    public KundeRepo(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<KundeEntity>> GetAllKundeAsync(bool includeProjekt)
    {
        var kundelist = await _appDbContext.Kunder.ToListAsync();
        return kundelist;
    }

    public async Task<KundeEntity> GetKundeByIdAsync(Guid kundeId)
    {
        var kunder = await _appDbContext.Kunder.Where(k => k.Kid == kundeId).FirstOrDefaultAsync();
        return kunder;
    }
}
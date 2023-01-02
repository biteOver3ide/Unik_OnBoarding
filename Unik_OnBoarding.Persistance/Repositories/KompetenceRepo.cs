using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DatabaseContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class KompetenceRepo : BaseRepo<KompetenceEntity>, IKompetencerRepository
{
    public KompetenceRepo(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<KompetenceEntity>> GetAllKompetencerAsync()
    {
        var kompetencelist = await _appDbContext.Kompetencerne.ToListAsync();
        return kompetencelist;
    }

    public async Task<KompetenceEntity> GetKompetencerByIdAsync(Guid kompetencerId)
    {
        var kompetence = await _appDbContext.Kompetencerne.Where(k => k.KompetenceId == kompetencerId).FirstOrDefaultAsync();
        return kompetence;
    }
}
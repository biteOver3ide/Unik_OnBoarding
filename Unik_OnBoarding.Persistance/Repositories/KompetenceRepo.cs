using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class KompetenceRepo : BaseRepo<KompetenceEntity>, IKompetencerRepository
{
    public KompetenceRepo(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<KompetenceEntity>> GetAllKompetencerAsync()
    {
        var kompetencelist = new List<KompetenceEntity>();
        kompetencelist = await _appDbContext.Kompetencerne.ToListAsync();
        return kompetencelist;
    }

    public async Task<KompetenceEntity> GetKompetencerByIdAsync(Guid kompetencerId)
    {
        var kompetence = new KompetenceEntity();
        kompetence = await _appDbContext.Kompetencerne.Where(k => k.KompetenceId == kompetencerId).FirstOrDefaultAsync();
        return kompetence;
    }
}
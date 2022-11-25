using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class ProjektRepository : BaseRepository<Projekt>, IProjectRepository
{
    public ProjektRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<IReadOnlyList<Projekt>> GetAllProjektAsync(bool includeKunde)
    {
        var projektList = new List<Projekt>();
        projektList = includeKunde
            ? await _appDbContext.Projektes.Include(k => k.KundeId).ToListAsync()
            : await _appDbContext.Projektes.ToListAsync();
        return projektList;
    }

    public async Task<Projekt> GetProjektByIdAsync(Guid projektId, bool includeKunde)
    {
        var projekt = new Projekt();
        projekt = includeKunde
            ? await _appDbContext.Projektes.Include(k => k.KundeId).FirstOrDefaultAsync(p => p.ProjektId == projektId)
            : await GetByIdAsync(projektId);
        return projekt;
    }
}
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

    public async Task<List<Projekt>> GetAllProjektAsync(bool includeKunde)
    {
        var projektList = new List<Projekt>();
        projektList = await _appDbContext.Projektes.ToListAsync();
        return projektList;
    }

    public async Task<Projekt> GetProjektByIdAsync(Guid projektId)
    {
        var projekt = new Projekt();
        projekt = await _appDbContext.Projektes.Where(p => p.ProjektId == projektId).FirstOrDefaultAsync();
        return projekt;
    }
}
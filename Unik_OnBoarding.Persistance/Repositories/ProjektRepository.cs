﻿using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class ProjektRepository : BaseRepository<ProjektEntity>, IProjectRepository
{
    public ProjektRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<ProjektEntity>> GetAllProjektAsync(bool includeKunde)
    {
        var projektList = new List<ProjektEntity>();
        projektList = await _appDbContext.Projektes.ToListAsync();
        return projektList;
    }

    public async Task<ProjektEntity> GetProjektByIdAsync(Guid projektId)
    {
        var projekt = new ProjektEntity();
        projekt = await _appDbContext.Projektes.Where(p => p.ProjektId == projektId).FirstOrDefaultAsync();
        return projekt;
    }
}
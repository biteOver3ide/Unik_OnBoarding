using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DbContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class MedarbejderRepo : BaseRepository<MedarbejderEntity>, IMedarbejderRepository
{
    public MedarbejderRepo(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<MedarbejderEntity>> GetAllMedarbejderAsync(bool includeProjekt)
    {
        var medarbejderlist = new List<MedarbejderEntity>();
        medarbejderlist = await _appDbContext.Medarbejder.ToListAsync();
        return medarbejderlist;
    }

    public async Task<MedarbejderEntity> GetMedarbejderByIdAsync(Guid medarbejderId)
    {
        var medarbejderlist = new MedarbejderEntity();
        medarbejderlist = await _appDbContext.Medarbejder.Where(m => m.MedarbejderId == medarbejderId).FirstOrDefaultAsync();
        return medarbejderlist;
    }
}
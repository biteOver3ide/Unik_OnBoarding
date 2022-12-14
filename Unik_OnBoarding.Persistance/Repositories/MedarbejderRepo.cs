using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DatabaseContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class MedarbejderRepo : BaseRepo<MedarbejderEntity>, IMedarbejderRepository
{
    public MedarbejderRepo(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<MedarbejderEntity>> GetAllMedarbejderAsync(bool includeProjekt)
    {
        var medarbejderlist = await _appDbContext.Medarbejder.ToListAsync();
        return medarbejderlist;
    }

    public async Task<MedarbejderEntity> GetMedarbejderByIdAsync(Guid medarbejderId, string UserId)
    {
        var medarbejderlist = await _appDbContext.Medarbejder.Where(m => m.MedarbejderId == medarbejderId).FirstOrDefaultAsync();
        return medarbejderlist;
    }
}
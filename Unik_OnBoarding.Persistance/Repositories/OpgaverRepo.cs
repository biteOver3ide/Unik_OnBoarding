using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Domain.Model;
using Unik_OnBoarding.Persistance.DatabaseContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class OpgaverRepo : BaseRepo<OpgaverEntity>, IOpgaverRepository
{
    public OpgaverRepo(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<List<OpgaverEntity>> GetAllOpgaverAsync()
    {
        var opgaverlist = new List<OpgaverEntity>();
        opgaverlist = await _appDbContext.Opgaver.ToListAsync();
        return opgaverlist;
    }

    public async Task<OpgaverEntity> GetOpgaverByIdAsync(Guid opgaverId)
    {
        var opgaver = new OpgaverEntity();
        opgaver = await _appDbContext.Opgaver.Where(o => o.OpgaveId == opgaverId).FirstOrDefaultAsync();
        return opgaver;
    }
}
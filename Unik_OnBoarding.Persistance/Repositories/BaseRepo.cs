using Microsoft.EntityFrameworkCore;
using Unik_OnBoarding.Application.Interfaceses;
using Unik_OnBoarding.Persistance.DatabaseContext;

namespace Unik_OnBoarding.Persistance.Repositories;

public class BaseRepo<T> : IAsyncRepository<T> where T : class
{
    protected readonly AppDbContext _appDbContext;

    public BaseRepo(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _appDbContext.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _appDbContext.Set<T>().ToListAsync();
    }

    public async Task<T> AddAsync(T entity)
    {
        await _appDbContext.Set<T>().AddAsync(entity);
		await _appDbContext.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _appDbContext.Entry(entity).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _appDbContext.Set<T>().Remove(entity);
        await _appDbContext.SaveChangesAsync();
    }
}
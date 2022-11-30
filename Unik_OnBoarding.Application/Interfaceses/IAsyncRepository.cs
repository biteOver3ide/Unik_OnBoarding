namespace Unik_OnBoarding.Application.Interfaceses;

public interface IAsyncRepository<T> where T : class
{
    Task<T> GetByIdAsync(Guid id); // get single entity 
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T> AddAsync(T entity); // Return entity after insertion 
    Task UpdateAsync (T entity);// Return No Content 
    Task DeleteAsync (T entity);// Return No Content 
}
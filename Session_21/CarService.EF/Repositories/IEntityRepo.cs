namespace CarService.EF.Repositories;

public interface IEntityRepo<TEntity>
{
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(Guid id);
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(Guid id, TEntity entity);
    Task DeleteAsync(Guid id);
}

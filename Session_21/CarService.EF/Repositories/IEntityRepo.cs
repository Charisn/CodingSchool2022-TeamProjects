using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public interface IEntityRepo<TEntity>
{
    Task<List<TEntity>> GetAllAsync();
    TEntity? GetById(Guid id);
    Task Create(TEntity entity);
    Task Update(Guid id, TEntity entity);
    Task Delete(Guid id);
}

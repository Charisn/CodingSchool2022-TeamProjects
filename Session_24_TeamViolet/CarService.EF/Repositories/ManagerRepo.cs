using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.EF.Repositories;

public class ManagerRepo : IEntityRepo<Manager>
{
    private readonly CarServiceContext _context;
    public ManagerRepo(CarServiceContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(Manager entity)
    {
        await _context.Managers.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(Guid id)
    {
        var foundManager = await _context.Managers.SingleOrDefaultAsync(manager => manager.ID == id);
        if (foundManager is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        _context.Managers.Remove(foundManager);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Manager>> GetAllAsync()
    {
        return await _context.Managers.ToListAsync();
    }

    public async Task<Manager?> GetByIdAsync(Guid id)
    {
        return await _context.Managers.Where(manager => manager.ID == id).SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(Guid id, Manager entity)
    {
        var foundManager = await _context.Managers.SingleOrDefaultAsync(manager => manager.ID == id);
        if (foundManager is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundManager.Name = entity.Name;
        foundManager.Surname = entity.Surname;
        foundManager.SalaryPerMonth = entity.SalaryPerMonth;
        await _context.SaveChangesAsync();
    }
}

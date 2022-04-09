using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.EF.Repositories;

public class EngineerRepo : IEntityRepo<Engineer>
{
    private readonly CarServiceContext _context;
    public EngineerRepo(CarServiceContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(Engineer entity)
    {
        await _context.Engineers.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(Guid id)
    {
        var foundEngineer = await _context.Engineers.SingleOrDefaultAsync(manager => manager.ID == id);
        if (foundEngineer is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        _context.Engineers.Remove(foundEngineer);
        await _context.SaveChangesAsync();
    }
    public async Task<List<Engineer>> GetAllAsync()
    {
        return await _context.Engineers.ToListAsync();
    }

    public async Task<Engineer?> GetByIdAsync(Guid id)
    {
        return await _context.Engineers.Where(engineer => engineer.ID == id).SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(Guid id, Engineer entity)
    {
        var foundEngineer = await _context.Engineers.SingleOrDefaultAsync(manager => manager.ID == id);
        if (foundEngineer is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundEngineer.Name = entity.Name;
        foundEngineer.Surname = entity.Surname;
        foundEngineer.SalaryPerMonth = entity.SalaryPerMonth;
        await _context.SaveChangesAsync();
    }
}

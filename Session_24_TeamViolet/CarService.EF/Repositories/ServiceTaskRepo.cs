using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.EF.Repositories;

public class ServiceTaskRepo : IEntityRepo<ServiceTask>
{
    private readonly CarServiceContext _context;

    public ServiceTaskRepo(CarServiceContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(ServiceTask entity)
    {
        await _context.ServiceTasks.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(Guid id)
    {
        var foundServiceTask = await _context.ServiceTasks.SingleOrDefaultAsync(serviceTask => serviceTask.ID == id);
        if (foundServiceTask is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        _context.ServiceTasks.Remove(foundServiceTask);
        await _context.SaveChangesAsync();
    }

    public async Task<List<ServiceTask>> GetAllAsync()
    {
        return await _context.ServiceTasks.ToListAsync();
    }

    public async Task<ServiceTask?> GetByIdAsync(Guid id)
    {
        return await _context.ServiceTasks.Where(serviceTask => serviceTask.ID == id).SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(Guid id, ServiceTask entity)
    {
        var foundServiceTask = await _context.ServiceTasks.SingleOrDefaultAsync(serviceTask => serviceTask.ID == id);
        if (foundServiceTask is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundServiceTask.Code = entity.Code;
        foundServiceTask.Hours = entity.Hours;
        await _context.SaveChangesAsync();
    }
}

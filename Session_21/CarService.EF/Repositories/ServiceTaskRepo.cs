using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class ServiceTaskRepo : IEntityRepo<ServiceTask>
{
    private readonly CarServiceContext context;
    public async Task CreateAsync(ServiceTask entity)
    {
        using var context = new CarServiceContext();
        context.ServiceTasks.Add(entity);
        await context.SaveChangesAsync();
    }
    public async Task DeleteAsync(Guid id)
    {
        using var context = new CarServiceContext();
        var foundServiceTask = context.ServiceTasks.SingleOrDefault(serviceTask => serviceTask.Id == id);
        if (foundServiceTask is null)
            return;
        context.ServiceTasks.Remove(foundServiceTask);
        await context.SaveChangesAsync();
    }

    public List<ServiceTask> GetAll()
    {
        using var context = new CarServiceContext();
        return context.ServiceTasks.ToList();
    }

    public async Task<List<ServiceTask>> GetAllAsync()
    {
        await using var context = new CarServiceContext();
        return await context.ServiceTasks.ToListAsync();
    }

    public async Task<ServiceTask?> GetByIdAsync(Guid id)
    {
        using var context = new CarServiceContext();
        return context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
    }

    public async Task UpdateAsync(Guid id, ServiceTask entity)
    {
        using var context = new CarServiceContext();
        var foundServiceTask = context.ServiceTasks.SingleOrDefault(serviceTask => serviceTask.Id == id);
        if (foundServiceTask is null)
            return;
        foundServiceTask.Code = entity.Code;
        foundServiceTask.Hours = entity.Hours;
        await context.SaveChangesAsync();
    }
}

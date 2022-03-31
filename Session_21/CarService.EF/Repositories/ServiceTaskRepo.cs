using CarService.EF.Context;
using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class ServiceTaskRepo : IEntityRepo<ServiceTask>
{
    public async Task Create(ServiceTask entity)
    {
        using var context = new CarServiceContext();
        context.ServiceTasks.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
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

    public ServiceTask? GetById(Guid id)
    {
        using var context = new CarServiceContext();
        return context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
    }

    public async Task Update(Guid id, ServiceTask entity)
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

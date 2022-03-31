using CarService.EF.Context;
using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class ManagerRepo : IEntityRepo<Manager>
{
    public async Task Create(Manager entity)
    {
        using var context = new CarServiceContext();
        context.Managers.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        using var context = new CarServiceContext();
        var foundManager = context.Managers.SingleOrDefault(manager => manager.Id == id);
        if (foundManager is null)
            return;
        context.Managers.Remove(foundManager);
        await context.SaveChangesAsync();
    }

    public List<Manager> GetAll()
    {
        using var context = new CarServiceContext();
        return context.Managers.ToList();
    }

    public Manager? GetById(Guid id)
    {
        using var context = new CarServiceContext();
        return context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
    }

    public async Task Update(Guid id, Manager entity)
    {
        using var context = new CarServiceContext();
        var foundManager = context.Managers.SingleOrDefault(manager => manager.Id == id);
        if (foundManager is null)
            return;
        foundManager.Name = entity.Name;
        foundManager.Surname = entity.Surname;
        foundManager.SalaryPerMonth = entity.SalaryPerMonth;
        await context.SaveChangesAsync();
    }
}

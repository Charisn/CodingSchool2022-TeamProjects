using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class ManagerRepo : IEntityRepo<Manager>
{
    public async Task CreateAsync(Manager entity)
    {
        using var context = new CarServiceContext();
        context.Managers.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        using var context = new CarServiceContext();
        var foundManager = context.Managers.SingleOrDefault(manager => manager.Id == id);
        if (foundManager is null)
            return;
        context.Managers.Remove(foundManager);
        await context.SaveChangesAsync();
    }

    public async Task<List<Manager>> GetAllAsync()
    {
        using var context = new CarServiceContext();
        return await context.Managers.ToListAsync();
    }

    public async Task<Manager?> GetByIdAsync(Guid id)
    {
        using var context = new CarServiceContext();
        return context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
    }

    public async Task UpdateAsync(Guid id, Manager entity)
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

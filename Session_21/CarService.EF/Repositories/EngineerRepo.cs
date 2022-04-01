using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class EngineerRepo : IEntityRepo<Engineer>
{
    public async Task Create(Engineer entity)
    {
        using var context = new CarServiceContext();
        context.Engineers.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        using var context = new CarServiceContext();
        var foundEngineer = context.Engineers.SingleOrDefault(manager => manager.Id == id);
        if (foundEngineer is null)
            return;
        context.Engineers.Remove(foundEngineer);
        await context.SaveChangesAsync();
    }

    public async Task<List<Engineer>> GetAllAsync()
    {
        using var context = new CarServiceContext();
        return await context.Engineers.ToListAsync();
    }

    public Engineer? GetById(Guid id)
    {
        using var context = new CarServiceContext();
        return context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
    }

    public async Task Update(Guid id, Engineer entity)
    {
        using var context = new CarServiceContext();
        var foundEngineer = context.Engineers.SingleOrDefault(manager => manager.Id == id);
        if (foundEngineer is null)
            return;
        foundEngineer.Name = entity.Name;
        foundEngineer.Surname = entity.Surname;
        foundEngineer.SalaryPerMonth = entity.SalaryPerMonth;
        await context.SaveChangesAsync();
    }
}

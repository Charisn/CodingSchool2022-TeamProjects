using CarService.EF.Context;
using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class CarRepo : IEntityRepo<Car>
{
    private readonly CarServiceContext context;
    public async Task CreateAsync(Car entity)
    {
        using var context = new CarServiceContext();
        context.Cars.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        using var context = new CarServiceContext();
        var foundCar = context.Cars.SingleOrDefault(car => car.Id == id);
        if (foundCar is null)
            return;
        context.Cars.Remove(foundCar);
        await context.SaveChangesAsync();
    }

    public async Task AddAsync(Car entity)
    {
        AddLogic(entity, context);
        await context.SaveChangesAsync();
    }

    public async Task<List<Car>> GetAllAsync()
    {
        using var context = new CarServiceContext();
        return context.Cars.ToList();
    }

    public async Task<Car? >GetByIdAsync(Guid id)
    {
        using var context = new CarServiceContext();
        return context.Cars.Where(car => car.Id == id).SingleOrDefault();
    }

    public async Task UpdateAsync(Guid id, Car entity)
    {
        using var context = new CarServiceContext();
        var foundCar = context.Cars.SingleOrDefault(car => car.Id == id);
        if (foundCar is null)
            return;
        foundCar.Brand = entity.Brand;
        foundCar.Model = entity.Model;
        foundCar.RegistrationNumber = entity.RegistrationNumber;
        await context.SaveChangesAsync();
    }
    private void AddLogic(Car entity, CarServiceContext context)
    {
        if (entity.Id != Guid.Empty)
            throw new ArgumentException("Given entity should not have Id set", nameof(entity));

        context.Cars.Add(entity);
    }
}

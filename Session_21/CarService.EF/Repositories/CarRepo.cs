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
    public async Task Create(Car entity)
    {
        using var context = new CarServiceContext();
        context.Cars.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        using var context = new CarServiceContext();
        var foundCar = context.Cars.SingleOrDefault(car => car.Id == id);
        if (foundCar is null)
            return;
        context.Cars.Remove(foundCar);
        await context.SaveChangesAsync();
    }

    public List<Car> GetAll()
    {
        using var context = new CarServiceContext();
        return context.Cars.ToList();
    }

    public Task<List<Car>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Car? GetById(Guid id)
    {
        using var context = new CarServiceContext();
        return context.Cars.Where(car => car.Id == id).SingleOrDefault();
    }

    public async Task Update(Guid id, Car entity)
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
}

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
    private readonly CarServiceContext _context;
    public CarRepo()
    {
        _context = new CarServiceContext();
    }

    public async Task CreateAsync(Car entity)
    {
        _context.Cars.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        using var context = new CarServiceContext();
        var foundCar = context.Cars.SingleOrDefault(car => car.Id == id);
        if (foundCar is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        context.Cars.Remove(foundCar);
        await context.SaveChangesAsync();
    }
    public async Task<List<Car>> GetAllAsync()
    {        
        return _context.Cars.ToList();
    }

    public async Task<Car? >GetByIdAsync(Guid id)
    {
        return _context.Cars.Where(car => car.Id == id).SingleOrDefault();
    }

    public async Task UpdateAsync(Guid id, Car entity)
    {
        var foundCar = _context.Cars.SingleOrDefault(car => car.Id == id);
        if (foundCar is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundCar.Brand = entity.Brand;
        foundCar.Model = entity.Model;
        foundCar.RegistrationNumber = entity.RegistrationNumber;
        await _context.SaveChangesAsync();
    }
}

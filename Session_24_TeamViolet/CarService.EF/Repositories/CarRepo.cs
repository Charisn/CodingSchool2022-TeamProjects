using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.EF.Repositories;

public class CarRepo : IEntityRepo<Car>
{
    private readonly CarServiceContext _context;
    public CarRepo(CarServiceContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Car entity)
    {
        await _context.Cars.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        using var context = new CarServiceContext();
        var foundCar = context.Cars.SingleOrDefault(car => car.ID == id);
        if (foundCar is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        _context.Cars.Remove(foundCar);
        await context.SaveChangesAsync();
    }
    public async Task<List<Car>> GetAllAsync()
    {
        return await _context.Cars.ToListAsync();
    }

    public async Task<Car?> GetByIdAsync(Guid id)
    {
        return await _context.Cars.Where(car => car.ID == id).SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(Guid id, Car entity)
    {
        var foundCar = await _context.Cars.SingleOrDefaultAsync(car => car.ID == id);
        if (foundCar is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundCar.Brand = entity.Brand;
        foundCar.Model = entity.Model;
        foundCar.RegistrationNumber = entity.RegistrationNumber;
        await _context.SaveChangesAsync();
    }
}

using CarService.EF.Repositories;
using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.MockData;

public class MockCarRepo : IEntityRepo<Car>
{
    private List<Car> _car = new List<Car>() { new Car(), new Car() };
    public async Task CreateAsync(Car entity)
    {
        _car.Add(entity);
        return;
    }

    public async Task DeleteAsync(Guid id)
    {
        var foundCar = _car.SingleOrDefault(x => x.Id.Equals(id));
        if (foundCar is null)
            return;
        _car.Remove(foundCar);
        return;
    }

    public List<Car> GetAll()
    {
        return _car;
    }

    public Task<List<Car>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Car?> GetByIdAsync(Guid id)
    {
        return _car.SingleOrDefault(x => x.Id.Equals(id));
    }

    public async Task UpdateAsync(Guid id, Car entity)
    {
        var foundCar = _car.SingleOrDefault(x => x.Id.Equals(id));
        if (foundCar is null)
            return;
        foundCar.Brand = entity.Brand;
        foundCar.Model = entity.Model;
        foundCar.RegistrationNumber = entity.RegistrationNumber;
        return;
    }
}

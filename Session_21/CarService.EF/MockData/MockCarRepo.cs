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
    public Task Create(Car entity)
    {
        _car.Add(entity);
        return Task.CompletedTask;
    }

    public Task Delete(Guid id)
    {
        var foundCar = _car.SingleOrDefault(x => x.Id.Equals(id));
        if (foundCar is null)
            return Task.CompletedTask;
        _car.Remove(foundCar);
        return Task.CompletedTask;
    }

    public List<Car> GetAll()
    {
        return _car;
    }

    public Car? GetById(Guid id)
    {
        return _car.SingleOrDefault(x => x.Id.Equals(id));
    }

    public Task Update(Guid id, Car entity)
    {
        var foundCar = _car.SingleOrDefault(x => x.Id.Equals(id));
        if (foundCar is null)
            return Task.CompletedTask;
        foundCar.Brand = entity.Brand;
        foundCar.Model = entity.Model;
        foundCar.RegistrationNumber = entity.RegistrationNumber;
        return Task.CompletedTask;
    }
}

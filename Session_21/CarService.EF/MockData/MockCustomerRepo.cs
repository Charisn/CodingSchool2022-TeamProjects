using CarService.EF.Repositories;
using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.MockData;

public class MockCustomerRepo : IEntityRepo<Customer>
{
    private List<Customer> _customer = new List<Customer>() { new Customer(), new Customer() };

    public Task Create(Customer entity)
    {
        _customer.Add(entity);
        return Task.CompletedTask;
    }

    public Task Delete(Guid id)
    {
        var foundCustomer = _customer.SingleOrDefault(x => x.Id.Equals(id));
        if (foundCustomer is null)
            return Task.CompletedTask;
        _customer.Remove(foundCustomer);
        return Task.CompletedTask;
    }

    public List<Customer> GetAll()
    {
        return _customer;
    }

    public Customer? GetById(Guid id)
    {
        return _customer.SingleOrDefault(x => x.Id.Equals(id));
    }

    public Task Update(Guid id, Customer entity)
    {
        var foundCustomer = _customer.SingleOrDefault(x => x.Id.Equals(id));
        if (foundCustomer is null)
            return Task.CompletedTask;
        foundCustomer.Surname = entity.Surname;
        foundCustomer.Phone = entity.Phone;
        foundCustomer.Name = entity.Name;
        foundCustomer.TIN = entity.TIN;
        return Task.CompletedTask;
    }
}

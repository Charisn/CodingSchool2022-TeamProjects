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
    private List<Customer> _customer = new List<Customer>() { new Customer()
        {
            Name = "John",
            Surname = "Eskioglou",
            Phone = "6982783322",
            TIN = "123456789"
        } };

    public async Task CreateAsync(Customer entity)
    {
        _customer.Add(entity);
        return;
    }

    public async Task DeleteAsync(Guid id)
    {
        var foundCustomer = _customer.SingleOrDefault(x => x.Id.Equals(id));
        if (foundCustomer is null)
            return;
        _customer.Remove(foundCustomer);
        return;
    }

    public List<Customer> GetAll()
    {
        return _customer;
    }

    public async Task<List<Customer>> GetAllAsync()
    {
        return _customer;
    }

    public async Task<Customer?> GetByIdAsync(Guid id)
    {
        return _customer.SingleOrDefault(x => x.Id.Equals(id));
    }

    public async Task UpdateAsync(Guid id, Customer entity)
    {
        var foundCustomer = _customer.SingleOrDefault(x => x.Id.Equals(id));
        if (foundCustomer is null)
            return;
        foundCustomer.Surname = entity.Surname;
        foundCustomer.Phone = entity.Phone;
        foundCustomer.Name = entity.Name;
        foundCustomer.TIN = entity.TIN;
        return;
    }
}

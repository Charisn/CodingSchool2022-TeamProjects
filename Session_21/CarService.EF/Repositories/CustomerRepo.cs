using CarService.EF.Context;
using CarService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class CustomerRepo : IEntityRepo<Customer>
{
    public async Task Create(Customer entity)
    {
        using var context = new CarServiceContext();
        context.Customers.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        using var context = new CarServiceContext();
        var foundCustomer = context.Customers.SingleOrDefault(car => car.Id == id);
        if (foundCustomer is null)
            return;
        context.Customers.Remove(foundCustomer);
        await context.SaveChangesAsync();
    }

    public List<Customer> GetAll()
    {
        using var context = new CarServiceContext();
        return context.Customers.ToList();
    }

    public Customer? GetById(Guid id)
    {
        using var context = new CarServiceContext();
        return context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
    }

    public async Task Update(Guid id, Customer entity)
    {
        using var context = new CarServiceContext();
        var foundCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
        if (foundCustomer is null)
            return;
        foundCustomer.Name = entity.Name;
        foundCustomer.Surname = entity.Surname;
        foundCustomer.TIN = entity.TIN;
        foundCustomer.Phone = entity.Phone;
        await context.SaveChangesAsync();
    }
}

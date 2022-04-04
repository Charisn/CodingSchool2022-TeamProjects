using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class CustomerRepo : IEntityRepo<Customer>
{
    private readonly CarServiceContext _context;
    public CustomerRepo(CarServiceContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(Customer entity)
    {
        await _context.Customers.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var foundCustomer = await _context.Customers.SingleOrDefaultAsync(car => car.Id == id);
        if (foundCustomer is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        _context.Customers.Remove(foundCustomer);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Customer>> GetAllAsync()
    {
        return await _context.Customers.ToListAsync();
    }

    public async Task<Customer?> GetByIdAsync(Guid id)
    {
        return await _context.Customers.Where(customer => customer.Id == id).SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(Guid id, Customer entity)
    {
        var foundCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.Id == id);
        if (foundCustomer is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundCustomer.Name = entity.Name;
        foundCustomer.Surname = entity.Surname;
        foundCustomer.TIN = entity.TIN;
        foundCustomer.Phone = entity.Phone;
        await _context.SaveChangesAsync();
    }
}

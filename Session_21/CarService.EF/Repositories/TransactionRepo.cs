using CarService.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService.Models.Entities;

namespace CarService.EF.Repositories;

public class TransactionRepo : IEntityRepo<Transaction>
{
    private readonly CarServiceContext context;
    public async Task CreateAsync(Transaction entity)
    {
        using var context = new CarServiceContext();
        context.Transactions.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        using var context = new CarServiceContext();
        var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
        if (foundTransaction is null)
            return;
        context.Transactions.Remove(foundTransaction);
        await context.SaveChangesAsync();
    }

    public List<Transaction> GetAll()
    {
        using var context = new CarServiceContext();
        return context.Transactions.Include(transaction => transaction.TransactionLines).ToList();
    }

    public Task<List<Transaction>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Transaction?> GetByIdAsync(Guid id)
    {
        using var context = new CarServiceContext();
        return context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
    }

    public async Task UpdateAsync(Guid id, Transaction entity)
    {
        using var context = new CarServiceContext();
        var foundTransaction = context.Transactions.Include(transaction => transaction.TransactionLines).SingleOrDefault(transaction => transaction.Id == id);
        if (foundTransaction is null)
            return;
        foundTransaction.CarID = entity.CarID;
        foundTransaction.ManagerID = entity.ManagerID;
        foundTransaction.CustomerID = entity.CustomerID;
        foundTransaction.TransactionLines = entity.TransactionLines;
        await context.SaveChangesAsync();
    }
}

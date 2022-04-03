using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Repositories;

public class TransactionLinesRepo : IEntityRepo<TransactionLine>
{
    private readonly CarServiceContext _context;
    public TransactionLinesRepo()
    {
        _context = new CarServiceContext();
    }
    public async Task CreateAsync(TransactionLine entity)
    {
        using var context = new CarServiceContext();
        context.TransactionLines.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        using var context = new CarServiceContext();
        var foundTransactionLine = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.Id == id);
        if (foundTransactionLine is null)
            return;
        context.TransactionLines.Remove(foundTransactionLine);
        await context.SaveChangesAsync();
    }

    public async Task<List<TransactionLine>> GetAllAsync()
    {
        await using var context = new CarServiceContext();
        return await _context.TransactionLines.ToListAsync();
    }

    public async Task<TransactionLine?> GetByIdAsync(Guid id)
    {
        using var context = new CarServiceContext();
        return context.TransactionLines.Where(transaction => transaction.Id == id).SingleOrDefault();
    }

    public async Task UpdateAsync(Guid id, TransactionLine entity)
    {
        using var context = new CarServiceContext();
        var foundTransactionLine = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.Id == id);
        if (foundTransactionLine is null)
            return;
        foundTransactionLine.TransactionId = entity.TransactionId;
        foundTransactionLine.ServiceTaskID = entity.ServiceTaskID;
        foundTransactionLine.EngineerID = entity.EngineerID;
        foundTransactionLine.ServiceTask = entity.ServiceTask;
        foundTransactionLine.Engineer = entity.Engineer;
        await context.SaveChangesAsync();
    }
}

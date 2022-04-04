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
    public TransactionLinesRepo(CarServiceContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(TransactionLine entity)
    {
        await _context.TransactionLines.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var foundTransactionLine = await _context.TransactionLines.SingleOrDefaultAsync(transactionLine => transactionLine.Id == id);
        if (foundTransactionLine is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        _context.TransactionLines.Remove(foundTransactionLine);
        await _context.SaveChangesAsync();
    }

    public async Task<List<TransactionLine>> GetAllAsync()
    {
        return await _context.TransactionLines.ToListAsync();
    }

    public async Task<TransactionLine?> GetByIdAsync(Guid id)
    {
        return await _context.TransactionLines.Where(transaction => transaction.Id == id).SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(Guid id, TransactionLine entity)
    {
        var foundTransactionLine = await _context.TransactionLines.SingleOrDefaultAsync(transactionLine => transactionLine.Id == id);
        if (foundTransactionLine is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundTransactionLine.TransactionId = entity.TransactionId;
        foundTransactionLine.ServiceTaskID = entity.ServiceTaskID;
        foundTransactionLine.EngineerID = entity.EngineerID;
        foundTransactionLine.ServiceTask = entity.ServiceTask;
        foundTransactionLine.Engineer = entity.Engineer;
        await _context.SaveChangesAsync();
    }
}

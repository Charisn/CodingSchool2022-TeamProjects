using CarService.EF.Context;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.EF.Repositories;

public class TransactionRepo : IEntityRepo<Transaction>
{
    private readonly CarServiceContext _context;
    public TransactionRepo(CarServiceContext context)
    {
        _context = context;
    }
    public async Task CreateAsync(Transaction entity)
    {
        await _context.Transactions.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var foundTransaction = await _context.Transactions.SingleOrDefaultAsync(transaction => transaction.ID == id);
        if (foundTransaction is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        _context.Transactions.Remove(foundTransaction);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Transaction>> GetAllAsync()
    {
        return await _context.Transactions.Include(x => x.Car).Include(x => x.Manager).Include(x => x.Customer).Include(x => x.TransactionLines).ToListAsync();
    }

    public async Task<Transaction?> GetByIdAsync(Guid id)
    {
        return await _context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefaultAsync();
    }

    public async Task UpdateAsync(Guid id, Transaction entity)
    {
        var foundTransaction = await _context.Transactions.Include(transaction => transaction.TransactionLines).SingleOrDefaultAsync(transaction => transaction.ID == id);
        if (foundTransaction is null)
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        foundTransaction.CarID = entity.CarID;
        foundTransaction.ManagerID = entity.ManagerID;
        foundTransaction.CustomerID = entity.CustomerID;
        foundTransaction.TransactionLines = entity.TransactionLines;
        await _context.SaveChangesAsync();
    }
}

using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(transaction => transaction.Id);
        builder.HasMany(transaction => transaction.TransactionLines).WithOne(transactionLine => transactionLine.Transaction);
        builder.HasOne(transaction => transaction.Manager).WithMany(manager => manager.Transactions);
        builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions);
        builder.HasOne(transaction => transaction.Car).WithMany(car => car.Transcations);
    }
}

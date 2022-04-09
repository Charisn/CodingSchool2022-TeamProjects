using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(transaction => transaction.ID);

        builder.Property(transaction => transaction.TotalPrice).HasColumnType("decimal(10,2)");
        builder.HasOne(transaction => transaction.Manager).WithMany(manager => manager.Transactions).HasForeignKey(transaction => transaction.ManagerID).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(transaction => transaction.Car).WithMany(car => car.Transcations).HasForeignKey(transaction => transaction.CarID).OnDelete(DeleteBehavior.Restrict);
    }
}

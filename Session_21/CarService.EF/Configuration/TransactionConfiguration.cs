using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Configuration;

internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(transaction => transaction.Id);

        //builder.HasMany(transaction => transaction.TransactionLines).WithOne().HasForeignKey(transactionLine => transactionLine.Id);
        //builder.HasOne(transaction => transaction.Manager).WithMany().HasForeignKey(transaction => transaction.ManagerID);
        //builder.HasOne(transaction => transaction.Customer).WithMany().HasForeignKey(transaction => transaction.CustomerID);
        //builder.HasOne(transaction => transaction.Car).WithMany().HasForeignKey(transaction => transaction.CarID);
    }
}

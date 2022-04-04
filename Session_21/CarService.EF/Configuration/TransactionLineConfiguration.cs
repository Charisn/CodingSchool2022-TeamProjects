using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Configuration;

internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
{
    public void Configure(EntityTypeBuilder<TransactionLine> builder)
    {
        builder.HasKey(transactionLine => transactionLine.Id);

        builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(manager => manager.TransactionLines).OnDelete(DeleteBehavior.NoAction);
    }
}

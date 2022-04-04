using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
{
    public void Configure(EntityTypeBuilder<TransactionLine> builder)
    {
        builder.HasKey(transactionLine => transactionLine.Id);

        builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(manager => manager.TransactionLines).OnDelete(DeleteBehavior.NoAction);
    }
}

using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
{
    public void Configure(EntityTypeBuilder<TransactionLine> builder)
    {
        builder.HasKey(transactionLine => transactionLine.ID);

        builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transline => transline.TransactionID).OnDelete(DeleteBehavior.NoAction);
    }
}

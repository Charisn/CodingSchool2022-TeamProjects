using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
{
    public void Configure(EntityTypeBuilder<TransactionLine> builder)
    {
        builder.HasKey(transactionLine => transactionLine.ID);

        builder.Property(transLine => transLine.Hours).HasColumnType("decimal(10,2)");
        builder.Property(transLine => transLine.Price).HasColumnType("decimal(10,2)");
        builder.Property(transLine => transLine.PricePerHour).HasColumnType("decimal(10,2)");
        builder.HasOne(transLine => transLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transline => transline.TransactionID).OnDelete(DeleteBehavior.NoAction);
    }
}

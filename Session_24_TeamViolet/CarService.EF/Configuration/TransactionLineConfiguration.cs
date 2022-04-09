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

        //TODO:ondelete cascade ?!??
        builder.HasOne(transLine => transLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transline => transline.TransactionID);
        //!?
        builder.HasOne(transline => transline.Engineer).WithMany(engineer => engineer.TransactionLines).HasForeignKey(transline => transline.EngineerID).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(transline => transline.ServiceTask).WithMany(servicetask => servicetask.TransactionLines).HasForeignKey(transline => transline.ServiceTaskID).OnDelete(DeleteBehavior.Restrict);
    }
}

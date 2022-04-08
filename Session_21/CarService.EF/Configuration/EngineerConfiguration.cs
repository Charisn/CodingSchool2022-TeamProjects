using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class EngineerConfiguration : IEntityTypeConfiguration<Engineer>
{
    public void Configure(EntityTypeBuilder<Engineer> builder)
    {

        builder.HasKey(engineer => engineer.ID);
        builder.Property(engineer => engineer.Name).HasMaxLength(50);
        builder.Property(engineer => engineer.Surname).HasMaxLength(50);

        builder.HasOne(engineer => engineer.Manager).WithMany(transline => transline.Engineers).HasForeignKey(engineer => engineer.ManagerID);
    }
}

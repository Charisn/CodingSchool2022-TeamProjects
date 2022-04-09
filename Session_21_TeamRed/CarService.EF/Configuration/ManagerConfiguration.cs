using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class ManagerConfiguration : IEntityTypeConfiguration<Manager>
{
    public void Configure(EntityTypeBuilder<Manager> builder)
    {
        builder.HasKey(customer => customer.ID);
        builder.Property(customer => customer.Name).HasMaxLength(50);
        builder.Property(customer => customer.Surname).HasMaxLength(50);

        builder.HasMany(manager => manager.Engineers).WithOne().HasForeignKey(manager => manager.ID);
    }
}

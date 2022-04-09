using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class ManagerConfiguration : IEntityTypeConfiguration<Manager>
{
    public void Configure(EntityTypeBuilder<Manager> builder)
    {
        builder.HasKey(manager => manager.ID);
        builder.Property(manager => manager.Name).HasMaxLength(50);
        builder.Property(manager => manager.Surname).HasMaxLength(50);
        builder.Property(manager => manager.SalaryPerMonth).HasColumnType("decimal(10,2)");
    }
}

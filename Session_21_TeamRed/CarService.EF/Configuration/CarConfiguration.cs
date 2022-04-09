using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(car => car.ID);
        builder.Property(car => car.Brand).HasMaxLength(50);
        builder.Property(car => car.Model).HasMaxLength(15);
        builder.Property(car => car.RegistrationNumber).HasMaxLength(50);
    }
}

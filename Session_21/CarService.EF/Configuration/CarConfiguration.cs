using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Configuration;

internal class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(car => car.Id);
        builder.Property(car => car.Id).HasMaxLength(50);

        builder.Property(car => car.Brand).HasMaxLength(50);
        builder.Property(car => car.Model).HasMaxLength(15);
        builder.Property(car => car.RegistrationNumber).HasMaxLength(50);
    }
}

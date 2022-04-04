﻿using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {

        builder.HasKey(customer => customer.Id);
        builder.Property(customer => customer.Name).HasMaxLength(50);
        builder.Property(customer => customer.Phone).HasMaxLength(15);
        builder.Property(customer => customer.TIN).HasMaxLength(30);
    }
}

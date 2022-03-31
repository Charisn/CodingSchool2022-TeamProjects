using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Library.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID);
            builder.Property(x => x.Name).ValueGeneratedOnAdd().HasMaxLength(50);
            builder.Property(x => x.SurName).ValueGeneratedOnAdd().HasMaxLength(50);
            builder.Property(x => x.SalaryPerMonth).ValueGeneratedOnAdd();
            builder.Property(x => x.EmployeeType).ValueGeneratedOnAdd();
            builder.Property(x => x.FullName).ValueGeneratedOnAdd().HasMaxLength(101);
        }
    }
}

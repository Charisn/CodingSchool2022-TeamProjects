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
    internal class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID);
            builder.Property(x => x.PetStatus).ValueGeneratedOnAdd();
            builder.Property(x => x.Cost).ValueGeneratedOnAdd();
            builder.Property(x => x.Breed).ValueGeneratedOnAdd().HasMaxLength(50);
            builder.Property(x => x.AnimalType).ValueGeneratedOnAdd().HasMaxLength(50);
        }
    }
}

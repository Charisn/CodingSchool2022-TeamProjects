using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.EF.Configuration;

internal class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
{
    public void Configure(EntityTypeBuilder<ServiceTask> builder)
    {

        builder.HasKey(servicetask => servicetask.Id);
        builder.Property(serviceTask => serviceTask.Code).HasMaxLength(100);
        builder.Property(serviceTask => serviceTask.Description).HasMaxLength(200);
    }
}

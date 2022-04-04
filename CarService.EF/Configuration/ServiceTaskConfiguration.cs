using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

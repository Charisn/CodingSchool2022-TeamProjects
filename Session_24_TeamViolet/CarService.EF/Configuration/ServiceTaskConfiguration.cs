using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarService.EF.Configuration;

internal class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
{
    public void Configure(EntityTypeBuilder<ServiceTask> builder)
    {

        builder.HasKey(servicetask => servicetask.ID);
        builder.Property(serviceTask => serviceTask.Code).HasMaxLength(100);
        builder.Property(serviceTask => serviceTask.Description).HasMaxLength(200);

        builder.Property(serviceTask => serviceTask.Hours).HasColumnType("decimal(10,2)");
    }
}

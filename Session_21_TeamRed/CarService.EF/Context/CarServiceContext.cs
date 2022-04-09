using CarService.EF.Configuration;
using CarService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.EF.Context;

public class CarServiceContext : DbContext
{
    public DbSet<Car> Cars { get; set; }

    public DbSet<ServiceTask> ServiceTasks { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Manager> Managers { get; set; }

    public DbSet<Engineer> Engineers { get; set; }

    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionLine> TransactionLines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new ManagerConfiguration());
        modelBuilder.ApplyConfiguration(new CarConfiguration());
        modelBuilder.ApplyConfiguration(new ServiceTaskConfiguration());
        modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
        modelBuilder.ApplyConfiguration(new EngineerConfiguration());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbCarService-Blazor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        optionsBuilder.UseSqlServer(connString);
    }
}

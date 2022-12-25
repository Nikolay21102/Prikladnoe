using Microsoft.EntityFrameworkCore;
using ShopApi.Entities.Configuration;
using ShopApi.Entities.Models;

namespace ShopApi.Entities;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }
}
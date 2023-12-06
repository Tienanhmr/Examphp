
using System.Collections.Generic;
using System.Reflection.Emit;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public Microsoft.EntityFrameworkCore.DbSet<Department> Departments { get; set; }
    public Microsoft.EntityFrameworkCore.DbSet<Employee> Employees { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure relationships, constraints, etc.
    }
}

public class ModelBuilder
{
}

public class DbContextOptions<T>
{
}
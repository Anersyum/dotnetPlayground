using Microsoft.EntityFrameworkCore;
using ShadowProps.Models;

namespace ShadowProps;

internal sealed class DatabaseContext : DbContext
{
    private const string CONNECTION_STRING = "Data Source=ShadowProp.db";
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;

    public DatabaseContext() : base() {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(CONNECTION_STRING);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .Property<string>("ShadowProperty");

        base.OnModelCreating(modelBuilder);
    }
}

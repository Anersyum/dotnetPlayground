using DotNetPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPlayground.Data;

public class Baza : DbContext
{
    public DbSet<Maca> Mace { get; set; }
    public DbSet<User> Users { get; set; }

    public Baza(DbContextOptions<Baza> options) : base(options) 
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        List<User> users = new()
        {
            new User
            {
                Id = 1,
                FirstName = "Amor",
                LastName = "Osmić",
                FavouriteFood = "Krompir"
            },
            new User
            {
                Id = 2,
                FirstName = "Sara",
                LastName = "Šahinpašić",
                FavouriteFood = "Pizza"
            },
            new User
            {
                Id = 3,
                FirstName = "Ines",
                LastName = "Osmić",
                FavouriteFood = "Špagete"
            },
            new User
            {
                Id = 4,
                FirstName = "Jasko",
                LastName = "Kreho",
                FavouriteFood = "Burek"
            }
        };

        modelBuilder.Entity<User>()
            .HasData(users);
    }
}
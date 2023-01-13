using DotNetPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPlayground.Data;

public class Baza : DbContext
{
    public DbSet<Maca> Mace { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }

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
        List<Car> cars = new()
        {
            new Car
            {
                Id=1,
                Tip="Karavan",
                Marka="Audi",
                DatumKreiranja="09.01.2023"
            },
            new Car
            {
                Id=2,
                Tip="Limuzina",
                Marka="Škoda",
                DatumKreiranja="09.01.2023"

            },
            new Car
            {
                Id=3,
                Tip="Džip",
                Marka="Toyota",
                DatumKreiranja="09.01.2023"

            },
            new Car
            {
                Id=4,
                Tip="SUV",
                Marka="VW",
               DatumKreiranja="09.01.2023"

            }
        };

        modelBuilder.Entity<User>()
            .HasData(users);
        modelBuilder.Entity<Car>().HasData(cars);
    }
}
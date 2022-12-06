using DotNetPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPlayground.Data;

public class Baza : DbContext
{
    public DbSet<Maca> Mace { get; set; }
    public DbSet<User> Users { get; set; }

    public Baza(DbContextOptions<Baza> options) : base(options) 
    {
        // za upis dummy podataka u bazu 
        if (Users!.ToList().Count > 0)
            return;

        Users!.AddRange(
            new User
            {
                FirstName = "Amor",
                LastName = "Osmić",
                FavouriteFood = "Krompir"
            },
            new User
            {
                FirstName = "Sara",
                LastName = "Šahinpašić",
                FavouriteFood = "Pizza"
            },
            new User
            {
                FirstName = "Ines",
                LastName = "Osmić",
                FavouriteFood = "Špagete"
            },
            new User
            {
                FirstName = "Jasko",
                LastName = "Kreho",
                FavouriteFood = "Burek"
            }
        );

        this.SaveChanges();
    }
}
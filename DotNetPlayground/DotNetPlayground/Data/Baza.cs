using DotNetPlayground.Models;
using DotNetPlayground.RSI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPlayground.Data;

public class Baza : DbContext
{
    public DbSet<Maca> Mace { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Osoba> Osobe { get; set; }
    public DbSet<Student> Studenti { get; set; }
    public DbSet<Drzava> Drzave { get; set; }
    public DbSet<Opstina> Opstine { get; set; }
    public DbSet<Osoblje> Osoblje { get; set; }
    public DbSet<BezvezeModel> BezvezeModels { get; set; }

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
        List<Osoba> osobe = new()
        {
            new Osoba
            {
                Id = 1,
                Ime = "Amor",
                Prezime = "Osmić",
                NajdrazaHrana = "Krompir",
                DatumRodjenja=new DateTime(1995,12,01),
                Email="amor@gmx.com",
                DatumKreiranja=DateTime.Now
            },
            new Osoba
            {
                Id = 2,
                Ime = "Sara",
                Prezime = "Šahinpašić",
                NajdrazaHrana = "Pizza",
                DatumRodjenja=new DateTime(1995,03,23),
                Email="sara@gmx.com",
                DatumKreiranja=DateTime.Now
            },
            new Osoba
            {
                Id = 3,
                Ime = "Ines",
                Prezime = "Osmić",
                NajdrazaHrana = "Špagete",
                DatumRodjenja=new DateTime(1998,11,20),
                Email="ines@gmx.com"
            },
            new Osoba
            {
                Id = 4,
                Ime = "Jasko",
                Prezime = "Kreho",
                NajdrazaHrana = "Burek",
                DatumRodjenja=new DateTime(1994,01,24),
                Email="jasko@gmx.com"
                            }
        };

        modelBuilder.Entity<User>()
            .HasData(users);
        modelBuilder.Entity<Car>().HasData(cars);
        modelBuilder.Entity<Osoba>().HasData(osobe);

        modelBuilder.Entity<Osoblje>().HasData(new Osoblje
        {
            Id = 1,
            Username = "Admin",
            Password = "admin"
        });
    }
}
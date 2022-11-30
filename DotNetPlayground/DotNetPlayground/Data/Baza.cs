using DotNetPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetPlayground.Data;

public class Baza : DbContext
{
    public DbSet<Maca> Mace { get; set; }

    public Baza(DbContextOptions<Baza> options) : base(options) { }
}
using DotNetPlayground.Data;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Servisi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<SaberiDvaBrojaServis_Z1>(); //registrovan servis
//builder.Services.AddScoped<OduzmiPaSaberi_Z1>();

builder.Services.AddDbContext<Baza>(config =>
{
    config.UseSqlite(builder.Configuration.GetConnectionString("Sqlite"));
});

builder.Services.AddScoped<IKalkulator_Z1, OduzmiPaSaberi_Z1 >();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

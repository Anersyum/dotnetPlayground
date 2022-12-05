using DotNetPlayground.Data;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Models;
using DotNetPlayground.Repositories;
using DotNetPlayground.Servisi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// set up cors (moram vidjeti što ne pušta localhost)
builder.Services.AddCors(option =>
{
    option.AddPolicy(name: "allowAngularLocalHost", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
            .SetIsOriginAllowed(isOriginAllowed: _ => true)
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<SaberiDvaBrojaServis_Z1>(); //registrovan servis
//builder.Services.AddScoped<OduzmiPaSaberi_Z1>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<Baza>(config =>
{
    config.UseSqlite(builder.Configuration.GetConnectionString("Sqlite"));
});

builder.Services.AddScoped<IKalkulator, OduzmiPaSaberi_Z1 >();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("allowAngularLocalHost");

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

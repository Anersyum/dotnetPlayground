using DotNetPlayground.Data;
using DotNetPlayground.Interfaces;
using DotNetPlayground.Middleware;
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
//<<<<<<< HEAD
//=======
builder.Services.AddScoped<IUserRepository, UserRepositoryNew>();
//>>>>>>> 6fefbc87084fd890c652f4525492dbd7558dd5d3

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

app.UseMiddleware<ExampleMiddleware>();

app.UseCors("allowAngularLocalHost");
app.UseExceptionHandler("/error");
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

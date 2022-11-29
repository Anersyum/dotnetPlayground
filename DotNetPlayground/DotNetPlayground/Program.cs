using DotNetPlayground.Interfaces;
using DotNetPlayground.Servisi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<SaberiDvaBrojaServis_Z1>(); //registrovan servis
//builder.Services.AddScoped<OduzmiPaSaberi_Z1>();

builder.Services.AddScoped<IKalkulator, OduzmiPaSaberi_Z1 >();

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

using Microsoft.EntityFrameworkCore;
using MilesCarRental.Business;
using MilesCarRental.Business.Interfaces;
using MilesCarRental.Repository;
using MilesCarRental.Repository.Interfaces;
//using MilesCarRental.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("MilesCarRentalConnectionString");
builder.Services.AddDbContext<MilesCarRentalContext>(
    options => options.UseSqlServer(connectionString)
);

builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<ICarBusiness, CarBusiness>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

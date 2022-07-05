using BankCardDetails.API.Data;
using BankCardDetails.API.Repositories;
using BankCardDetails.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext injection
string connectionString = builder.Configuration.GetConnectionString("BankCardsDbConnection");
builder.Services.AddDbContext<DataContext>(d => d.UseSqlServer(connectionString));

// AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddTransient<BankCardService>();
builder.Services.AddTransient<BankCardRepository>();

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

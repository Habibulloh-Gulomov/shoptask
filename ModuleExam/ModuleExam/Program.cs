using Microsoft.EntityFrameworkCore;
using ModuleExam.Data;
using ModuleExam.Services;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString: "Host=localhost;Database=ShopExam;Username=postgres;Password=20050421"));

// Add services to the container.

builder.Services.AddScoped<IShopService, ShopService>();

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

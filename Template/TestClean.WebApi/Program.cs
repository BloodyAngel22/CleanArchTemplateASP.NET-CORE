using FluentValidation;
using Microsoft.EntityFrameworkCore;
using TestClean.Application.Mappings;
using TestClean.Application.Services;
using TestClean.Application.Validators;
using TestClean.Core.IRepositories;
using TestClean.Core.Models;
using TestClean.Infrastructure;
using TestClean.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Product, Guid>, ProductRepository>();
builder.Services.AddScoped<ProductService>();

builder.Services.AddScoped<IValidator<ProductDTO>, ProductValidator>();

builder.Services.AddAutoMapper(typeof(MapProduct).Assembly);

//Change connection string to your own. Settings in appsettings.json
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMongoDB(
	builder.Configuration.GetSection("MongoDbSettings:ConnectionString").Value ?? throw new Exception("Connection string not found"), 
	builder.Configuration.GetSection("MongoDbSettings:DatabaseName").Value ?? throw new Exception("Database name not found")
));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
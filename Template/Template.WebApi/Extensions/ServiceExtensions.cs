using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Template.Application.DTOs;
using Template.Application.Mappings;
using Template.Application.Services;
using Template.Application.Validators;
using Template.Core.Entities;
using Template.Core.Interfaces;
using Template.Infrastructure.Persistence;
using Template.Infrastructure.Repositories;

namespace Template.WebApi.Extensions
{
    public static class ServiceExtensions
    {
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
		{
			// Repositories
            services.AddScoped<IRepository<Product, Guid>, ProductRepository>();

            // Services
            services.AddScoped<ProductService>();

            // Validators
            services.AddScoped<IValidator<ProductDTO>, ProductValidator>();

            // AutoMapper
            services.AddAutoMapper(typeof(MapProduct).Assembly);

            // DbContext
            services.AddDbContext<AppDbContext>(opt => opt.UseMongoDB(
                configuration.GetSection("MongoDbSettings:ConnectionString").Value ?? throw new Exception("Connection string not found"),
                configuration.GetSection("MongoDbSettings:DatabaseName").Value ?? throw new Exception("Database name not found")
            ));

            return services;
		}

		public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            return services;
        }
	}
}
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Template.Application.DTOs.Request;
using Template.Application.Services;
using Template.Application.Validators;
using Template.Core.Entities;
using Template.Core.IRepositories;
using Template.Infrastructure.Persistence;
using Template.Infrastructure.Repositories;

namespace Template.WebApi.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ProductService>();

        return services;
    }

    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<ProductDTORequest>, ProductValidator>();

        return services;
    }

    public static IServiceCollection AddMongo(this IServiceCollection services, string connectionString, string databaseName)
    {
        services.AddDbContext<MongoDbContext>(opt => opt.UseMongoDB(connectionString, databaseName));

        return services;
    }

    public static IServiceCollection AddPostgres(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<PostgresDbContext>(opt => opt.UseNpgsql(connectionString));

        return services;
    }
}
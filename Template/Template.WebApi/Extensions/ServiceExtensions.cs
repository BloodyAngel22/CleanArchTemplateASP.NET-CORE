using FluentValidation;
using Template.Application.DTOs.Request;
using Template.Application.Services;
using Template.Application.Validators;
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
        services.AddScoped<IValidator<ProductDTORequest>, ProductDTORequestValidator>();
        services.AddScoped<IValidator<PaginationDTORequest>, PaginationDTORequestValidator>();

        return services;
    }

    public static IServiceCollection AddMongo(this IServiceCollection services)
    {
        services.AddDbContext<MongoDbContext>();

        return services;
    }

    public static IServiceCollection AddPostgres(this IServiceCollection services)
    {
        services.AddDbContext<PostgresDbContext>();

        return services;
    }
}

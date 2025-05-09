using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Template.Infrastructure.Persistence;

namespace Template.WebApi.Extensions;

public static class MiddlewareExtensions
{
    public static void ConfigureRouting(this WebApplication app)
    {
        app.MapControllers();
    }

    public static IApplicationBuilder UseScalar(
        this WebApplication app,
        IWebHostEnvironment environment
    )
    {
        if (environment.IsDevelopment())
        {
            app.MapScalarApiReference(
                "docs",
                opt =>
                {
                    opt.WithTheme(ScalarTheme.DeepSpace);
                    opt.WithDownloadButton(true);
                }
            );
            app.MapOpenApi();
        }

        return app;
    }

    public static void UseDatabaseMigration(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<PostgresDbContext>();

        try
        {
            dbContext.Database.Migrate();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error applying migrations: {ex.Message}");
            throw;
        }
    }
}

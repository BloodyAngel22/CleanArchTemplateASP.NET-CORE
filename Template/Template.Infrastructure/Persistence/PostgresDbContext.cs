using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Template.Core.Entities;
using Template.Infrastructure.Extensions;

namespace Template.Infrastructure.Persistence;

public class PostgresDbContext(IConfiguration configuration, IHostEnvironment environment)
    : DbContext()
{
    private readonly IConfiguration _configuration = configuration;
    private readonly IHostEnvironment _environment = environment;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionStringOrThrow("Postgres"));

        if (_environment.IsDevelopment())
        {
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .EnableSensitiveDataLogging();
        }
    }

    public DbSet<Product> Products { get; set; }
}

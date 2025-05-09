using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Template.Core.Entities;
using Template.Infrastructure.Extensions;

namespace Template.Infrastructure.Persistence;

public class MongoDbContext(IConfiguration configuration, IHostEnvironment environment)
    : DbContext()
{
    private readonly IConfiguration _configuration = configuration;
    private readonly IHostEnvironment _environment = environment;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMongoDB(
            _configuration.GetSectionValueOrThrow("MongoDBSettings:ConnectionString"),
            _configuration.GetSectionValueOrThrow("MongoDBSettings:DatabaseName")
        );

        if (_environment.IsDevelopment())
        {
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .EnableSensitiveDataLogging();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasKey(x => x.Id);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Product> Products { get; set; }
}

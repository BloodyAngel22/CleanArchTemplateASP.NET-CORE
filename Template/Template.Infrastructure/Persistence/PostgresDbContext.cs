using Microsoft.EntityFrameworkCore;
using Template.Core.Entities;

namespace Template.Infrastructure.Persistence;

public class PostgresDbContext(DbContextOptions<PostgresDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}
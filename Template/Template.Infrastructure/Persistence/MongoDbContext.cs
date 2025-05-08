using Microsoft.EntityFrameworkCore;
using Template.Core.Entities;

namespace Template.Infrastructure.Persistence
{
	public class MongoDbContext(DbContextOptions<MongoDbContext> options) : DbContext(options)
	{
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasKey(x => x.Id);

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Product> Products { get; set; }
	}
}
using Microsoft.EntityFrameworkCore;
using Template.Core.Entities;

namespace Template.Infrastructure.Persistence
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasKey(x => x.Id);

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Product> Products { get; set; }
	}
}
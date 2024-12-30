using Microsoft.EntityFrameworkCore;
using TestClean.Core.Models;

namespace TestClean.Infrastructure
{
    public class AppDbContext: DbContext
    {
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasKey(x => x.Id);

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Product> Products { get; set; }
    }
}
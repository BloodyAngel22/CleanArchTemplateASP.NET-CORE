using Microsoft.EntityFrameworkCore;
using Template.Core.Entities;
using Template.Core.Interfaces;
using Template.Infrastructure.Persistence;

namespace Template.Infrastructure.Repositories
{
	public class ProductRepository : IRepository<Product, Guid>
	{
		private readonly AppDbContext _context;

		public ProductRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task AddAsync(Product entity)
		{
			try
			{
				var newProduct = new Product
				{
					Name = entity.Name,
					Price = entity.Price
				};

				await _context.Products.AddAsync(newProduct);
				await _context.SaveChangesAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task DeleteAsync(Guid id)
		{
			try
			{
				var product = await _context.Products.FindAsync(id) ?? throw new Exception("Product not found");

				_context.Products.Remove(product);

				await _context.SaveChangesAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<IEnumerable<Product>> GetAllAsync()
		{
			try
			{
				return await _context.Products.ToListAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Product> GetAsync(Guid id)
		{
			try
			{
				var product = await _context.Products.FindAsync(id) ?? throw new Exception("Product not found");

				return product;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task UpdateAsync(Guid id, Product entity)
		{
			try
			{
				var product = await _context.Products.FindAsync(id) ?? throw new Exception("Product not found");

				product.Name = entity.Name;
				product.Price = entity.Price;

				await _context.SaveChangesAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
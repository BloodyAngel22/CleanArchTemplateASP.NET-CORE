using Template.Core.IRepositories;
using Template.Core.Entities;
using Template.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Template.Infrastructure.Repositories;

public class ProductRepository(PostgresDbContext context) : IProductRepository
{
    private readonly PostgresDbContext _context = context;

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        var entities = await _context.Products.AsNoTracking().ToListAsync();
        return entities;
    }

    public async Task<Product> GetProductByIdAsync(Guid id)
    {
        var product = await _context.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Product not found");

        return product;
    }

    public async Task AddProductAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(Product product)
    {
        var productToUpdate = await _context.Products.FindAsync(product.Id) ?? throw new Exception("Product not found");

        productToUpdate.Name = product.Name;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(Guid id)
    {
        var product = await _context.Products.FindAsync(id) ?? throw new Exception("Product not found");

        _context.Products.Remove(product);

        await _context.SaveChangesAsync();
    }
}
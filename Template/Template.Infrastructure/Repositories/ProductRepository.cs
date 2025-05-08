using Template.Core.IRepositories;
using Template.Core.Entities;
using Template.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Template.Infrastructure.Repositories;

public class ProductRepository(PostgresDbContext context) : IProductRepository
{
    private readonly PostgresDbContext _context = context;

    public async Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken = default)
    {
        var entities = await _context.Products.AsNoTracking().ToListAsync(cancellationToken);
        return entities;
    }

    public async Task<Product> GetProductByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var product = await _context.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken) ?? throw new Exception("Product not found");

        return product;
    }

    public async Task AddProductAsync(Product product, CancellationToken cancellationToken = default)
    {
        await _context.Products.AddAsync(product, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateProductAsync(Product product, CancellationToken cancellationToken = default)
    {
        var productToUpdate = await _context.Products.FindAsync(product.Id, cancellationToken) ?? throw new Exception("Product not found");

        productToUpdate.Name = product.Name;

        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteProductAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var product = await _context.Products.FindAsync(id, cancellationToken) ?? throw new Exception("Product not found");

        _context.Products.Remove(product);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
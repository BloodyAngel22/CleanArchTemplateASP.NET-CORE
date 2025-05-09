using Template.Core.Entities;

namespace Template.Core.IRepositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken);
    Task<IEnumerable<Product>> GetProductsWithPaginationAsync(
        int page,
        int pageSize,
        CancellationToken cancellationToken
    );
    Task<Product> GetProductByIdAsync(Guid id, CancellationToken cancellationToken);
    Task AddProductAsync(Product product, CancellationToken cancellationToken);
    Task UpdateProductAsync(Product product, CancellationToken cancellationToken);
    Task DeleteProductAsync(Guid id, CancellationToken cancellationToken);
}

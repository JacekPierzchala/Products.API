using Products.Models;

namespace Products.API.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync(QueryParameters queryParameters);
        Task<Product> GetProductByIdAsync(Guid id);
        Task<Product> CreateProduct(Product product);

    }
}

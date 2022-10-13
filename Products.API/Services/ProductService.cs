using Microsoft.EntityFrameworkCore;
using Products.API.Data;
using Products.Models;

namespace Products.API.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductsDataContext _context;

        public ProductService(ProductsDataContext context)
        {
            _context = context;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _context.Products.FirstOrDefaultAsync(c => c.Id == id);

        }

        public async Task<IEnumerable<Product>> GetProductsAsync(QueryParameters queryParameters)
        {
            IQueryable<Product> products = _context.Products;
            if (!string.IsNullOrEmpty(queryParameters.Description))
            {
                products = products.Where(x => x.Description
                .ToLower().Contains(queryParameters.Description.ToLower()));
            }
            if (!string.IsNullOrEmpty(queryParameters.ProductCode))
            {
                products = products.Where(x => x.ProductCode.ToLower()
                == queryParameters.ProductCode.ToLower());
            }

            if (!string.IsNullOrEmpty(queryParameters.ProductName))
            {
                products = products.Where(x => x.ProductName
                .ToLower().Contains(queryParameters.ProductName.ToLower()));
            }

            return await products.Include(r=>r.Category).ToListAsync();

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Products.Models;

namespace Products.API.Data
{
    public class ProductsDataContext:DbContext
    {
        public ProductsDataContext(DbContextOptions<ProductsDataContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

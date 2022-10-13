using Microsoft.EntityFrameworkCore;
using Products.API.Data;
using Products.Models;

namespace Products.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ProductsDataContext _context;

        public CategoryService(ProductsDataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}

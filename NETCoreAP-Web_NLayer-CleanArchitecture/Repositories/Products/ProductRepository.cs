using Microsoft.EntityFrameworkCore;

namespace App.Repositories.Products
{
    public class ProductRepository(AppDbContext context) : GenericRepository<Product>(context), IProductRepository
    {
        public async Task<List<Product>> GetTopPriceProductsAsync(int count)
        {
            return await Context.Products
                .OrderByDescending(p => p.Price)
                .Take(count)
                .ToListAsync();
        }
    }
}

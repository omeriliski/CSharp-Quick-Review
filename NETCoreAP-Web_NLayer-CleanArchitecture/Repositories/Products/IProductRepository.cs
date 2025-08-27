using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories.Products
{
    public interface IProductRepository:IProductRepository<Product>
    {
        public Task<List<Product>> GetTopPriceProductsAsync(int count);
    }
}

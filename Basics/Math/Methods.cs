
using Basics1;

namespace Helper
{
    public class Methods
    {
        public Product CreateProduct()
        {
            Product product = new()
            {
                Name = "Chair",
                Price = 20
            };
            return product;
        }
    }
}

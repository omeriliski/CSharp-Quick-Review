
namespace OOP2
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int _id, string _name, decimal price)
        {
            Id = _id;
            Name = _name;
            Price = price;
        }
    }
}
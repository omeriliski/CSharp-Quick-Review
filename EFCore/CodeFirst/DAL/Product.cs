
namespace CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }  // Entity Framework will use this as the primary key if it's named "Id" or "<ClassName>Id"
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}

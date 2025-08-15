
namespace CodeFirst.DAL
{
    public class Product
    {
        public int Id { get; set; }  // Entity Framework will use this as the primary key if it's named "Id" or "<ClassName>Id"
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }
        public int CategoryId { get; set; }  // Foreign key to the Category table
        public Category Category { get; set; }  // Navigation property to the Category entity
    }
}

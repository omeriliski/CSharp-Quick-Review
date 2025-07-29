
namespace Basics1
{
    // default access modifier for classes is internal
    public class Product
    {
        // default access modifier for class members is private
        public string Name { get; set; }
        public decimal Price { get; set; }
        private int Stock { get; set; }
        internal string Description { get; set; }

        protected string MetaTitle { get; set; }
        protected internal string MetaDescription { get; set; }

        public const string Category = "Furniture"; // Constant value, cannot be changed
        public readonly decimal Tax;

        // Constructor to initialize readonly fields
        public Product()
        {
            Tax = 0.19m; // Example tax rate
        }
        public void IncStock(){
            Stock++;  // While this is private, it can be accessed within the same class.
        }
    }
}

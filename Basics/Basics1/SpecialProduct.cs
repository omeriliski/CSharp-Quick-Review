
namespace Basics1
{
    internal class SpecialProduct: Product
    {
        public string SpecialDescription { get; set; }

        public void SetMetaTitle(string title)
        {
            Product product1 = new Product();
            // product1.MetaTitle = title; // This line would cause an error because MetaTitle is protected in Product.
            MetaTitle = title; // Accessing protected member from base class
            //(protected veri miras alinan siniflardan dogrudan ulasilir, nesne örnegi üzerinden ulasilmaz)

            // MetaDescription is protected internal, so it can be accessed here
            MetaDescription = title + " - Special Edition";
            product1.MetaDescription = title + " - Special Edition"; // This is valid because MetaDescription is protected internal
            //(protected internal veri miras alinan siniflardan dogrudan ulasilir ve ayni zamanda nesne örnegi üzerinden de ulasilir)
        }
    }
}

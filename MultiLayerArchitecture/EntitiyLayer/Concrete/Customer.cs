
namespace EntitiyLayer.Concrete
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
        public bool CustomerStatus { get; set; }
    }
}


namespace OOP2
{
    public class Table: Product
    {
        public string Type { get; set; }

        public Table(int id, string name, decimal price, string type):base(id, name,price)
        {
            Type = type;
        }
    }
}

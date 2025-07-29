
namespace OOP3
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"Person=> Id: {Id}, Name: {Name}");
        }
    }
}

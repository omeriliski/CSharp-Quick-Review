

namespace OOP3
{
    public class Employee: Person
    {
        public override void Display()
        {
            Console.WriteLine($"Employee=> Id: {Id}, Name: {Name}");
        }
    }
}

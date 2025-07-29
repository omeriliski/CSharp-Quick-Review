
namespace OOP
{
    public abstract class Person
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public static string Field1;
        public string Field2;
        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname}");
        }
        public abstract void ComputeSalaries(); // abstract method must be implemented by derived classes
                                                // abstract methods do not have a body
        public virtual void ComputeVacations() // virtual methods must have a body
        {
            Console.WriteLine("Vacations are calculated");
        }
    }
}

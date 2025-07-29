

namespace OOP
{
    public sealed class Employee: Person
    {
        public string Jobdescription { get; set; }

        public override void ComputeSalaries()
        {
            Console.WriteLine("Salaries are here calculated.");
        }
        //public override void Display() // This method can not be overridden because it is not virtual in the base class.
        //{

        //}
        public override void ComputeVacations() // Virtual method can be overridden in derived classes but it is not mandatory.
        {
            Console.WriteLine("Vacations are calculated for employee.");
        }
    }
}

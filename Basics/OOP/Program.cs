// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("---------Abstract Classes--------------");
// Abstract classe are used as a base for other classes.
// We cannot create an instance of an abstract class.
// Abstract classes can have properties which can be used by derived classes.
// Abstract classes can have abstract methods, which must be implemented by derived classes.
// Abstract classes can also have non-abstract methods, which can be used by derived classes.

Employee employee = new Employee();
employee.Name = "John";
employee.Surname = "Doe";
employee.Jobdescription = "Software Engineer";

employee.Display();

Person.Field1 = "Some static value"; // Static field can be accessed without an instance of the class.
//Person.Field2 = "Another static value"; // Non-static field can be accessed only through an instance of the class

Console.WriteLine("---------Virtual Methods--------------");
// virtual methods musst not be overwritten
// virtual properties can be overridden in derived classes

Console.WriteLine("-----------Sealed Classes-------------");
// sealed classes cannot be inherited from.


Console.WriteLine("-----------Delegates-------------");
// Delegates are type-safe function pointers.
// Singlecast delegates can point to a single method.
// Multicast delegates can point to multiple methods.


Console.WriteLine("-----------Events-------------");
// Events are a way to notify subscribers when something happens.
// Events are based on delegates.



// See https://aka.ms/new-console-template for more information
using OOP3;
using System.Collections;

Console.WriteLine("------------Out--------------");
static int Calculate(int a, int b, out int multiplyResp)
{
    multiplyResp = a * b;
    return a + b;
}

int sumResult = Calculate(2, 3, out int multiplyResult);
Console.WriteLine($"sum: {sumResult} mulpiply: {multiplyResult}");

Console.WriteLine("------------Ref--------------");
// Ref keyword is used to pass a variable by reference. 
// This means that any changes made to the variable inside the method will be reflected outside the method.
int a = 10;
Console.WriteLine("a:" + a);
CalculateRef(ref a);
Console.WriteLine("a after ref:" + a);
static void CalculateRef(ref int a)
{
    a += 10;
}
Console.WriteLine("------------return in a method--------------");
static void Write()
{
    for (int i = 0; i < 10; i++)
    {
        if(i == 5)
        {
            return; // exits the method when i is 5
        }
        else {             
            Console.WriteLine(i);
        }
    }
} 

Write();

Console.WriteLine("----------using-------------");
// Using statement is used to ensure that the resources are disposed of properly.
//using (SqlConnection sqlConnection = new SqlConnection) { 
//};
Console.WriteLine("----------nullable types-------------");
int? i=null; // Nullable type can hold a value or null
if(i.HasValue)
{
    Console.WriteLine("i has value: " + i.Value);
}
else
{
    Console.WriteLine("i is null");
}
Console.WriteLine("----------Array Lists-------------");
ArrayList arrayList = [1, "Hello", 3.14];
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

// instead of ArrayList, use List<T> for type safety
Console.WriteLine("----------Dictionary-------------");
List<string> list = new() { "one", "two", "three" };

Console.WriteLine("----------Params-----------------");
// Params keyword allows passing a variable number of arguments to a method.
static void PrintNumbers(params int[] numbers)
{
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
}
PrintNumbers(1, 2, 3, 4, 5); // Params allows passing a variable number of arguments

Console.WriteLine("---------- Extension methods--------------");
string message = "Hello, World!";
message.Print(); // Using extension method to print the string. Extension methods allow adding new methods to existing types.

Console.WriteLine("---------- Encapsulation --------------");
// Encapsulation is the concept of wrapping data and methods into a single unit.

Console.WriteLine("---------- Polymorpfism --------------");
// Polymorphism allows methods to do different things based on the object it is acting upon.

Person person = new Person { Id = 1, Name = "John" };
person.Display(); // Calls Person's Display method
Employee employee = new Employee { Id = 2, Name = "Jane" };
employee.Display(); 

Person employee2 = new Employee { Id = 3, Name = "Doe" };
employee2.Display(); // Calls Employee's Display method due to polymorphism
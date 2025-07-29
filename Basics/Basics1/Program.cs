// See https://aka.ms/new-console-template for more information
using Basics1;

Product product = new() { Price=10, Name="Table" };

product.Description = "A wooden table";
product.MetaDescription = "A wooden table with a smooth finish"; // This is valid because MetaDescription is protected internal

Console.WriteLine($"Student Name: {product.Name}, Age: {product.Price}, Description: {product.Description}");

Console.WriteLine("-------------------Access Modifiers-----------------------");

//Access Modifiers
// public: Accessible from anywhere
// private: Accessible only within the same class
// internal: Accessible within the same assembly (project)

// protected: Accessible within the same class and derived
// protected internal: Accessible within the same assembly and derived classes
// private protected: Accessible within the same class and derived

Console.WriteLine("-------------------Casting/ Type Conversion-----------------------");
int number = 123;
long longNumber = number; // Implicit conversion: No data loss, e.g., int to long

long bigNumber = 123456789000;
int smallNumber = (int)bigNumber; // Explicit conversion, may lose data if bigNumber is too large
Console.WriteLine($"smallNumber: {smallNumber}");

Console.WriteLine("---------------------Boxing / Unboxing---------------------");
// Value types are stored in the stack, int, long, float, etc.
// Reference types are stored in the heap, string, class, etc.
// Boxing: Converting a value type to an ref type
// Unboxing: Converting a ref type back to a value type

int number2 = 42;
object boxedNumber = number2; // Boxing: int to object
Console.WriteLine($"boxed Number: {boxedNumber}");
int unboxedNumber = (int)boxedNumber; // Unboxing: object to int
//int unboxedNumber2 = Convert.ToInt32(boxedNumber); // Another way to unbox 
Console.WriteLine($"unboxed Number: {unboxedNumber}");

Console.WriteLine("---------------------int.Parse() / int.tryParse---------------------");
// int.Parse() throws an exception if the conversion fails
string numberString = "123";
try
{
    int parsedNumber = int.Parse(numberString);
    Console.WriteLine($"Parsed Number: {parsedNumber}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid format for int.Parse()");
}

int parsedNumber2;
bool issucceded = int.TryParse(numberString, out parsedNumber2);
Console.WriteLine($"Success:{issucceded}");
Console.WriteLine($"Parsed Number2: {parsedNumber2}");

Console.WriteLine("---------------------is operator---------------------");
// is: it ckecks if a variable can be cast to a specific type
object[] arr = { "fatih", 5, 5.4, false, "Mehmet", true, 40 };
foreach (var item in arr)
{
    if(item is string)
    {
        Console.WriteLine(item);
    }
}
Console.WriteLine("---------------------as operator---------------------");
// as: it tries to cast a variable to a specific type, if it fails, it returns null
foreach (var item in arr)
{
    string? stringData = item as string;
    Console.WriteLine(stringData ?? "Not a string");
    //if(stringData is null) // Alternative way to check if stringData is null
    //{
    //            Console.WriteLine("This is not a string");
    //}
    //else
    //{
    //    Console.WriteLine($"This is a string: {stringData}");
    //}
}

Console.WriteLine("---------------------const---------------------");
const double Pi = 3.14; // Pi is a constant value, it cannot be changed
Console.WriteLine($"Pi: {Pi}");

Console.WriteLine("---------------------difference between const and readonly ---------------------");
// const: compile-time constant, must be initialized at declaration
// readonly: can be assigned at runtime, but only once, either at declaration or in the constructor

Console.WriteLine($"Product Category: {Product.Category}");
Console.WriteLine($"Product Tax: {product.Tax}");

Console.WriteLine("---------------------difference between class and struct ---------------------");
// Class: Reference type, stored in heap, supports inheritance, can be null. The value is stored in the heap and accessed via a reference. Reference is stored in the stack.
// Struct: Value type, stored in stack, does not support inheritance, cannot be null.It is faster than class because it is stored in the stack. The value is stored directly in the stack, not a reference.


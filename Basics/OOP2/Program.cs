// See https://aka.ms/new-console-template for more information

using OOP2;

Console.WriteLine("---------------Constructors--------------");
Product product = new Product(1, "Laptop", 1500);
Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price} Euro");


Console.WriteLine("---------------Partial Class--------------");
// Using the partial class Person defined in Person.cs
Table table = new Table(2, "Dining Table", 300, "Wooden");


Console.WriteLine("---------------Delegates--------------");
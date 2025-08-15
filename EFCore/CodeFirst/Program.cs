// See https://aka.ms/new-console-template for more information

using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Initialize();

using(var _context = new AppDbContext())
{
    // add a new product
    //var product = new Product
    //{
    //    Name = "New Product 2",
    //    Price = 250,
    //    Stock = 250,
    //    Barcode = 012345
    //};
    //await _context.AddAsync(product);

    //var firstProduct = await _context.Products.FirstAsync();

    // update an existing product
    //firstProduct.Name = "Updated Product"; // EF will track this change, we don't need to use _context.Update(product);
    //_context.Update(new Product { Id = 5, Name = "New Product 1" });    // Second way to update, it updates the product which is not tracked

    // delete an existing product
    //_context.Products.Remove(firstProduct);
    //_context.Entry(firstProduct).State = EntityState.Deleted;  // we can also set the state explicitly, it's the same as Remove

    //await _context.SaveChangesAsync();
    //var products = await _context.Products.ToListAsync();

    //foreach (var p in products)
    //{
    //    var state= _context.Entry(p).State;
    //    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}, Barcode: {p.Barcode}, State: {state}");
    //}

    //-------------------------------------------------------------------------------------
    // Example of adding a new category and product
    //Category category = new() { Name = "Electronics" };

    //Product product = new()
    //{
    //    Name = "Laptop",
    //    Price = 1500,
    //    Stock = 10,
    //    Barcode = 123456,
    //    Category = category
    //};
    //_context.Products.Add(product);

    //-------------------------------------------------------------------------------------
    //Example of adding a new teacher and students
    Teacher teacher1 = new() { Name = "John", Surname = "Doe" };
    Teacher teacher2 = new() { Name = "Jane", Surname = "Doe" };
    Teacher teacher3 = new() { Name = "Mark", Surname = "Smith" };

    Student student1 = new() { Name = "Alice", Surname = "Smith", Teachers = new List<Teacher>() { teacher1, teacher2 } };
    Student student2 = new() { Name = "Bob", Surname = "Johnson", Teachers = new List<Teacher>() { teacher2, teacher3 } };

    _context.Students.Add(student1); 
    _context.Students.Add(student2);
    _context.SaveChanges();
}
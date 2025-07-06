// See https://aka.ms/new-console-template for more information

using Microsoft.Data.SqlClient;
using System.Data;

//create db connection
SqlConnection connection = new("Data Source=(localdb)\\MSSQLLocalDB; initial Catalog=my-database; integrated Security=true");
connection.Open();

// retrieve products data
SqlCommand command = new("Select * from Products", connection);
SqlDataAdapter adapter = new(command);
DataTable table = new();
adapter.Fill(table);

foreach (DataRow row in table.Rows)
{
    foreach (var item in row.ItemArray)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

// add category
SqlCommand command2 = new("insert into Categories (CategoryName) values (@v1)", connection);
command2.Parameters.AddWithValue("@v1", "Mezeler");
command2.ExecuteNonQuery();

// delete Category
Console.WriteLine("Enter the category name to delete:");
string categoryName = Console.ReadLine();
SqlCommand command3 = new("delete from Categories where CategoryName=@categoryName", connection);
command3.Parameters.AddWithValue("@categoryName", categoryName);
command3.ExecuteNonQuery();

// update Category
Console.WriteLine("Enter the categoryId to update:");
int categoryId = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the new category name:");
string newCategoryName = Console.ReadLine();

SqlCommand command4 = new("update Categories set CategoryName=@newCategoryName where CategoryId=@categoryId", connection);
command4.Parameters.AddWithValue("@categoryId", categoryId);
command4.Parameters.AddWithValue("@newCategoryName", newCategoryName);
command4.ExecuteNonQuery();

connection.Close();


// See https://aka.ms/new-console-template for more information

# region
// type conversion

string number = "123";
int convertedNumber1 = int.Parse(number);

// or using TryParse for safer conversion
if (int.TryParse(number, out int convertedNumber2))
{
   Console.WriteLine($"Converted number: {convertedNumber2}");
}
else
{
    Console.WriteLine("Conversion failed.");
}
#endregion

#region
// switch expression
int switch_on = 2;
switch (switch_on)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}
#endregion
Console.WriteLine("------------------------");
#region
//arrays
string[] citiesTurkey = new string[3];
citiesTurkey[0] = "Istanbul";
citiesTurkey[1] = "Ankara";
citiesTurkey[2] = "Izmir";

string[] citiesGermany = { "Berlin", "Munich", "Hamburg" }; 

string[] citiesUSA = ["New York", "Los Angeles"]; // .NET 8 + C# 12 syntax
#endregion

#region
//arrays methods
int index = Array.IndexOf(citiesUSA, "Los Angeles");
Console.WriteLine($"Index of 'Los Angeles': {index}");

int[] numbers = { 1, 2, 3, 4, 5 };
int maxNumber = numbers.Max();
Console.WriteLine($"Max number: {maxNumber}");

int minNumber = numbers.Min();
Console.WriteLine($"Min number: {minNumber}");
#endregion
Console.WriteLine("------------------------");
#region
// foreach loop
foreach (var city in citiesTurkey)
{
    Console.WriteLine(city);
}
#endregion
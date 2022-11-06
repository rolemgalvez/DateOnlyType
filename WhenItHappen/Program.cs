using System.Globalization;

// Welcome message
Console.WriteLine("When It Happen");
Console.WriteLine("--------------");
Console.WriteLine();

// Declare variables
string expectedDate = "23/12/2022";
string dateFormat = "dd/MM/yyyy";
string targetFormat = "MM/dd/yyyy";
CultureInfo dateRule = CultureInfo.InvariantCulture;
DateTime expectedDateInDateTime = DateTime.ParseExact(expectedDate, dateFormat, dateRule);
DateOnly expectedDateInDateOnly = DateOnly.ParseExact(expectedDate, dateFormat, dateRule);

// Show values
Console.WriteLine($"Expected Date               : {expectedDate}");
Console.WriteLine($"Expected Date Format        : {dateFormat}");
Console.WriteLine($"Expected Date Target Format : {targetFormat}");
Console.WriteLine($"Expected Date In DateTime   : {expectedDateInDateTime}");
Console.WriteLine($"Expected Date In DateOnly   : {expectedDateInDateOnly}");
Console.ReadLine();
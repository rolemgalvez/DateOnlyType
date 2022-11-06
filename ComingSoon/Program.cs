using System.Globalization;

// Welcome message
Console.WriteLine("Coming Soon");
Console.WriteLine("-----------");
Console.WriteLine();

// Declare variables
string assumeDate = "25/7/2069";
string dateFormat = "dd/M/yyyy";
string targetFormat = "MM/dd/yyyy";
CultureInfo dateRule = CultureInfo.InvariantCulture;
DateTime assumeDateInDateTime = DateTime.ParseExact(assumeDate, dateFormat, dateRule);
DateOnly assumeDateInDateOnly = DateOnly.ParseExact(assumeDate, dateFormat, dateRule);

// Show values
Console.WriteLine($"Assume Date               : {assumeDate}");
Console.WriteLine($"Assume Date Format        : {dateFormat}");
Console.WriteLine($"Assume Date Target Format : {targetFormat}");
Console.WriteLine($"Assume Date In DateTime   : {assumeDateInDateTime}");
Console.WriteLine($"Assume Date In DateOnly   : {assumeDateInDateOnly}");
Console.ReadLine();
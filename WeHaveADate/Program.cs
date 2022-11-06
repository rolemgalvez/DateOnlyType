

// Welcome message
Console.WriteLine("We Have A Date");
Console.WriteLine("--------------");
Console.WriteLine();

// Declare variables
string theDate = "9/6/1696";
DateTime theDateInDateTime = DateTime.Parse(theDate);
DateOnly theDateInDateOnly = DateOnly.Parse(theDate);

// Show values
Console.WriteLine($"A Date From String : {theDate}");
Console.WriteLine($"A Date From DateTime : {theDateInDateTime}");
Console.WriteLine($"A Date From DateOnly : {theDateInDateOnly}");
Console.ReadLine();
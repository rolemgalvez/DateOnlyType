

// Welcome message
Console.WriteLine("Happy Birthday");
Console.WriteLine("--------------");
Console.WriteLine();

// Declare variables
string birthday = "6/9/1969";
DateTime birthdayDateTime = DateTime.Parse(birthday);
DateOnly birthdayDateOnly = DateOnly.Parse(birthday);

// Show values
Console.WriteLine($"Birthday From String   : {birthday}");
Console.WriteLine($"Birthday From DateTime : {birthdayDateTime}");
Console.WriteLine($"Birthday From DateOnly : {birthdayDateOnly}");
Console.ReadLine();
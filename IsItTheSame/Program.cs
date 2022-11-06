

// Welcome message
Console.WriteLine("Is It The Same");
Console.WriteLine("--------------");
Console.WriteLine();

// Declare variables
DateTime dateTimeValue = DateTime.Now;
DateOnly dateOnlyValue = DateOnly.Parse(dateTimeValue.ToString("d"));

// Show values
Console.WriteLine($"Date Time Type Value : {dateTimeValue}");
Console.WriteLine($"Date Only Type Value : {dateOnlyValue}");
Console.ReadLine();
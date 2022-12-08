// String Manipulation

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("The current time is " + DateTime.Now);

// string name = "Bob";
// int messageQty = 3;
// decimal temperature = 34.4m;

// Console.Write("Hello, " + name);
// Console.Write("! You have " + messageQty);
// Console.Write(" messages in your inbox. The temperature is " + temperature + " celsius.");

// Escape chars
// \n = new line
// \t = tab
// \u#### = UTF-16 char
// Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
// Console.WriteLine("Invoice: 101\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.WriteLine("\nOutput Directory:\t");
// Console.Write(@"  c:\invoices");

// String interpolation
// Console.WriteLine($"\n\nHello, {name}! You have {messageQty} messages in your inbox. The temperature is {temperature} celsius.\n");

// String literal
// Console.WriteLine(@"Hello, Bobbo! 
//   You have some messages in your inbox. 
//   The temperature is measured in celsius.");

// string projectName = "ACME";

// string englishMessage = "View English output";
// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// string englishDirectory = $@"c:\Exercise\{projectName}\data.txt";
// string russianDirectory = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

// Console.WriteLine($"{englishMessage}:\n\t\t{englishDirectory}\n\n{russianMessage}:\n\t\t{russianDirectory}");

// ---------------------------------------------------------------------------------------------------------------------

// Type casting

// Casting decimal type
// int first = 7;
// int second = 5;
// decimal intQuotient = first / second;
// decimal quotient = (decimal)first / (decimal)second;
// Console.WriteLine("Integers:\t\t" + intQuotient);
// Console.WriteLine("Casted Decimals:\t" + quotient);

// int fahrenheit = 94;
// decimal celsius = (fahrenheit - 32) * (5m/9);

// Console.WriteLine($"The temperature is {celsius} Celsius.");

// ---------------------------------------------------------------------------------------------------------------------

// Class methods

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// ---------------------------------------------------------------------------------------------------------------------

// Conditionals

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Console.WriteLine(daysUntilExpiration);

// if (daysUntilExpiration == 0) 
// {
//   Console.WriteLine("Your subscription has expired.");
// } else if (daysUntilExpiration == 1) 
// {
//   Console.WriteLine("Your subscription expires within a day!");
//   discountPercentage = 20;
// } else if (daysUntilExpiration <= 5) 
// {
//   Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//   discountPercentage = 10;
// } else if (daysUntilExpiration <= 10) 
// {
//   Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (daysUntilExpiration <= 5 && daysUntilExpiration > 0) 
// {
//   Console.WriteLine($"Renew now and save {discountPercentage}%!");
// }

// ---------------------------------------------------------------------------------------------------------------------

// Arrays

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// ---------------------------------------------------------------------------------------------------------------------

// Iteration

// string[] names = { "Bob", "Conrad", "Grant" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

//----------------------------------------------------------------------------------------------------------------------

// string[] orderIds = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

// foreach (string orderId in orderIds) 
// {
//   if (orderId.StartsWith("B")) 
//   {
//     Console.WriteLine(orderId);
//   }
// }

// using Humanizer;

// Console.WriteLine("Quantities:");
// HumanizeQuantities();

// Console.WriteLine("\nDate/Time Manipulation:");
// HumanizeDates();

// static void HumanizeQuantities()
// {
//     Console.WriteLine("case".ToQuantity(0));
//     Console.WriteLine("case".ToQuantity(1));
//     Console.WriteLine("case".ToQuantity(5));
// }

// static void HumanizeDates()
// {
//     Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
//     Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
//     Console.WriteLine(TimeSpan.FromDays(1).Humanize());
//     Console.WriteLine(TimeSpan.FromDays(16).Humanize());
// }

//----------------------------------------------------------------------------------------------------------------------

// using System.Diagnostics;

// int result = Fibonacci(5);
// Console.WriteLine(result);

// static int Fibonacci(int n)
// {
//     Debug.Assert(n >= 0, $"{n} is negative and will cause failure.");
//     Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
//     Debug.WriteLine($"We are looking for the {n}th number");
    
//     int n1 = 0;
//     int n2 = 1;
//     int sum;

//     for (int i = 2; i <= n; i++)
//     {
//         sum = n1 + n2;
//         n1 = n2;
//         n2 = sum;
//         Debug.WriteLine("loop "  + i);
//         Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");    
//     }

//     return n == 0 ? n1 : n2;
// }

using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

// var salesFiles = FindFiles("stores");

// foreach (var file in salesFiles)
// {
//     Console.WriteLine(file);
// }

// IEnumerable<string> FindFiles(string folderName)
// {
//   List<string> salesFiles = new List<string>();

//   var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

//   foreach (var file in foundFiles)
//   {
//     // The file name will contain the full path, so only check the end of it
//     // if (file.EndsWith("sales.json"))
//     // {
//     //     salesFiles.Add(file);
//     // }
//     // var extension = Path.GetExtension(file);
//     var extension = Path.GetExtension(file);
//     if (extension == ".json")
//     {
//         salesFiles.Add(file);
//     }
//   }

//   return salesFiles;
// }

// string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

// Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
// Console.WriteLine(Path.Combine("stores","201"));
// returns:
// stores\201 on Windows
// stores/201 on macOS

// string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

// FileInfo info = new FileInfo(fileName);

// Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more

// var currentDirectory = Directory.GetCurrentDirectory();
// var storesDirectory = Path.Combine(currentDirectory, "stores");

// var salesFiles = FindFiles(storesDirectory);

// foreach (var file in salesFiles)
// {
//   Console.WriteLine(file);
// }

// Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));

// bool doesDirectoryExist = Directory.Exists("filePath");

// File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");

//----------------------------------------------------------------------------------------------------------------------

// Creating directories/files

// var currentDirectory = Directory.GetCurrentDirectory();
// var storesDirectory = Path.Combine(currentDirectory, "stores");

// var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
// Directory.CreateDirectory(salesTotalDir); 

// var salesFiles = FindFiles(storesDirectory);

// File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);

//----------------------------------------------------------------------------------------------------------------------

// Read/write files

// var currentDirectory = Directory.GetCurrentDirectory();
// var storesDirectory = Path.Combine(currentDirectory, "stores");

// var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
// Directory.CreateDirectory(salesTotalDir);   

// var salesFiles = FindFiles(storesDirectory);

// var salesTotal = CalculateSalesTotal(salesFiles);

// File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

// IEnumerable<string> FindFiles(string folderName)
// {
//     List<string> salesFiles = new List<string>();

//     var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

//     foreach (var file in foundFiles)
//     {
//         var extension = Path.GetExtension(file);
//         if (extension == ".json")
//         {
//             salesFiles.Add(file);
//         }
//     }

//     return salesFiles;
// }

// double CalculateSalesTotal(IEnumerable<string> salesFiles)
// {
//     double salesTotal = 0;
    
//     // Loop over each file path in salesFiles
//     foreach (var file in salesFiles)
//     {      
//         // Read the contents of the file
//         string salesJson = File.ReadAllText(file);
    
//         // Parse the contents as JSON
//         SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);
    
//         // Add the amount found in the Total field to the salesTotal variable
//         salesTotal += data?.Total ?? 0;
//     }
    
//     return salesTotal;
// }

// record SalesData (double Total);

//----------------------------------------------------------------------------------------------------------------------

// Reverse words in string

// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] split = pangram.Split(' ');
// string[] reversedSplit = new string[split.Length];

// for (int i = 0; i < split.Length; i++)
// {
//     char[] letters = split[i].ToCharArray();
//     Array.Reverse(letters);
//     reversedSplit[i] = new string(letters);
// }

// string reversed = String.Join(" ", reversedSplit);

// Console.WriteLine(reversed);

//----------------------------------------------------------------------------------------------------------------------

// Filter

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');

foreach (string order in orders) 
{
    if (order.StartsWith("B"))
    {
        Console.WriteLine(order);
    }
}
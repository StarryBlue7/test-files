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

string[] orderIds = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string orderId in orderIds) 
{
  if (orderId.StartsWith("B")) 
  {
    Console.WriteLine(orderId);
  }
}
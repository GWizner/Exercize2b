double userIn = 0;

Console.WriteLine("Pick a number:");
string userInput = Console.ReadLine();
double.TryParse(userInput, out userIn);
Console.WriteLine();
Console.WriteLine(userIn + 1);
Console.ReadLine();
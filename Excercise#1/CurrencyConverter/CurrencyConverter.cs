using System.Globalization;

Console.Write("Enter amount in USD: ");
double amount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.Write("Enter exchange rate from USD to EUR: ");
double rate = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

double result = amount * rate;

Console.Write($"Amount in EUR: {result:F2}");

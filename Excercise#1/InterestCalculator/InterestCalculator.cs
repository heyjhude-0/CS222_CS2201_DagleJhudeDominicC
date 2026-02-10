using System.Globalization;

Console.Write("Enter the principal amount: ");
double pAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter rate of interest: ");
double rate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter time in years: ");
int time = Convert.ToInt32(Console.ReadLine());

double result = (pAmount * rate * time) / 100;

Console.WriteLine($"Simple Interest: {result} ");
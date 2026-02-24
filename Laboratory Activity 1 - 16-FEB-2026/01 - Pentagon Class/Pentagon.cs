// See https://aka.ms/new-console-template for more information
using System.Security.Principal;

Pentagon p1 = new Pentagon();
Pentagon p2 = new Pentagon(5);

Console.WriteLine("Pentagon p1");
Console.WriteLine("--------------");
p1.Display();

Console.WriteLine();
Console.WriteLine("\nPentagon p2");
Console.WriteLine("--------------");
p2.Display();

public class Pentagon
{
    private double side;

    public Pentagon()
    {
        this.side = 0;
    }

    public Pentagon (double side)
    {
        this.side = side;
    }

    public double GetPerimeter(double side)
    {
        double perimeter =  5 * side;
        return perimeter;
    }

    public double GetArea(double side)
    {
        double area = (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
        return area;
    }

    public void Display()
    {
        Console.Write("Side length: " + side);
        Console.Write($"\nPerimeter: {GetPerimeter(side):F3}");
        Console.Write($"\nArea: {GetArea(side):F3}");

    }
}

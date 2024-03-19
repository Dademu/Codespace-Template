using System;
namespace TestConsole.Shapes;

public class Shapes
{
    // Base class for all shapes
}

public class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        return side * side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a square object
        Square square = new Square(5);

        // Calculate and print the area of the square
        double area = square.CalculateArea();
        Console.WriteLine("Area of the square: " + area);
    }
}

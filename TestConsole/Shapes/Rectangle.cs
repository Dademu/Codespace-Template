namespace TestConsole.Shapes;

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}
using TestConsole.Classes;
using TestConsole.Shapes;

// TextClass x = new TextClass() { square = 8 };

// Console.WriteLine(x.square);

// TextClass y = new TextClass() { square = 20 };

// y = x;

// Console.WriteLine(y.square);

// TextClass y = new TextClass((int)3);

// Console.WriteLine(y.square);

Shape x = new Shape();
x.Width = 10;
x.Height = 20;

Console.WriteLine(x.Area());

using System;
//принципу підстановки Лісков
class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

class Square
{
    public int Side { get; set; }

    public int GetSquareArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine(rect.GetRectangleArea()); // Виведе 50

        Square square = new Square { Side = 5 };
        Console.WriteLine(square.GetSquareArea()); // Виведе 25

        Console.ReadKey();
    }
}

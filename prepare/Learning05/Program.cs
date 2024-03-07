using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> Shapes = new List<Shape>();

        Square square1 = new Square("red", 2);
        Shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("blue", 2, 4);
        Shapes.Add(rectangle1);

        Circle circle1 = new Circle("yellow", 3);
        Shapes.Add(circle1);

        foreach(Shape s in Shapes)
        {
            Console.WriteLine($"{s} is {s.GetColor()}");
            Console.WriteLine($"{s} is {s.GetArea()} units large");
        }
        
    }
}
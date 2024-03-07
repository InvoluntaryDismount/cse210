public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor()
    {
        Console.WriteLine("What color is the shape?");
        _color = Console.ReadLine();
    }

    public abstract double GetArea();
}
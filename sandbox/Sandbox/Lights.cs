public class Lights : Device
{
    private string _color;

    public Lights(string name, string color) : base(name)
    {
        _color = color;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_name} has been running for {GetCurrentUptime()} and is the color {_color}.");
    }
}
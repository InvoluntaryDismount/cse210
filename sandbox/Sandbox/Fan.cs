public class Fan : Device
{
    private int _speed;
    
    // constructor
    public Fan(string name) : base(name)
    {
        _speed = 0;
    }

    public override void TurnOn()
    {
        base.TurnOn();
        SetFanSpeed();
    }
    public override void TurnOff()
    {
        base.TurnOff();
        _speed = 0;
    }

    public void SetFanSpeed()
    {
        Console.WriteLine($"What speed (in rpm) would you like to set for {_name}?");
        _speed = int.Parse(Console.ReadLine());    
    }

    public int GetFanSpeed()
    {
        return _speed;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_name} has been running for {GetCurrentUptime()} and has a current speed of {GetFanSpeed()}");
    }
}
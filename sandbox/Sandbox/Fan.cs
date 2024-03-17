public class Fan : Device
{
    private int _speed;
    
    // constructor
    public Fan(string name) : base(name)
    {
        _speed = 60;
    }

    public override void TurnOn()
    {
        base.TurnOn();
    }
    public override void TurnOff()
    {
        base.TurnOff();
        _speed = 0;
    }

    public void SetFanSpeed(int speedRPM)
    {
        _speed = speedRPM;    
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
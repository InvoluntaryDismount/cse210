public abstract class Device
{
    protected string _name;
    protected DateTime _startTime;
    protected bool isOn;

    public Device(string device_name)
    {
        _name = device_name;
    }

    public virtual void TurnOn()
    {
        // Only allow turning on if the device is currently off
        if (!isOn)
        {
            isOn = true;
            _startTime = DateTime.Now;
            Console.WriteLine($"{_name} has been turned on at {_startTime}");
        }
        else
        {
            Console.WriteLine($"{_name} is already turned on");
        }
    }

    public virtual void TurnOff()
    {
        // Only allow turning off if the device is currently on
        if (isOn)
        {
            isOn = false;
            TimeSpan uptime = DateTime.Now - _startTime;
            Console.WriteLine($"{_name} has been turned off. Uptime: {uptime}");
        }
        else
        {
            Console.WriteLine($"{_name} is already turned off");
        }
    }

    public TimeSpan GetCurrentUptime()
    {
        if (isOn)
        {
            return DateTime.Now - _startTime;
        }
        else
        {
            Console.WriteLine($"{_name} is currently turned off. Uptime is not applicable.");
            return TimeSpan.Zero; // Return zero if the device is off
        }
    }

    public void DisplayUptime()
    {
        Console.WriteLine($"Uptime: {GetCurrentUptime()}");
    }

    public abstract void DisplaySummary();


}
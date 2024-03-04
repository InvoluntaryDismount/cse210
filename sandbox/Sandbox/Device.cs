public class Device
{
    private string name;
    private DateTime startTime;
    private bool isOn;

    public Device(string deviceName)
    {
        name = deviceName;
    }

    public void TurnOn()
    {
        this.isOn = true;
        this.startTime = DateTime.Now;
        Console.WriteLine($"{name} has been turned on");
    }
    public void TurnOff()
    {
        this.isOn = false;
        Console.WriteLine($"{name} has been turned off");
    }

    public void Uptime()
    {
        if (isOn == true)
        {
            DateTime currentTime = DateTime.Now;
            var uptime = currentTime - startTime;
            Console.WriteLine($"{name} has been running for {uptime}");
        }

        else
        {
            Console.WriteLine($"{name} has not been turned on");
        }
    }


}
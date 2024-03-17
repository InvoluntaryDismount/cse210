public class Room
{
    private string _name;
    public List<Device> devices = new List<Device>();

    public Room(string name)
    {
        _name = name;
    }

    public void TurnOffAll()
    {
        foreach (var device in devices)
        {
            device.TurnOff();
        }
    }

    public void TurnOnAll()
    {
        foreach (var device in devices)
        {
            device.TurnOn();
        }
    }

    public void RoomSummary()
    {
        foreach (var device in devices)
        {
            device.DisplaySummary();
        }
    }
}
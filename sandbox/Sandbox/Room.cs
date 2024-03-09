public class Room
{
    private string _name;
    private List<Device> devices;

    public Room(string name)
    {
        _name = name;
        Lights lights1 = new Lights($"{_name} Lights", "white");
    }
}
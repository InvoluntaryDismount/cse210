class House
{
    private string _name;
    public List<Room> rooms = new List<Room>();

    public House(string name) {
        _name = name;
    }

    public void TurnOnAll()
    {
        foreach (var room in rooms)
        {
            room.TurnOnAll();
        }
    }
    public void TurnOffAll()
    {
        foreach (var room in rooms)
        {
            room.TurnOffAll();
        }
    }

    public void GetHouseSummary()
    {
        foreach (var room in rooms)
        {
            room.RoomSummary();
        }
    }
}
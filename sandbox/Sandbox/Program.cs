using System;

class Program
{
    static void Main(string[] args)
    {
        House house1 = new House("my house");


        // create living room
        Room livingRoom = new Room("living room");
        Lights livingRoomLights = new Lights("living room lights", "white");
        Fan livingRoomFan = new Fan("living room fan");

        // add living room devices and room to lists
        livingRoom.devices.Add(livingRoomLights);
        livingRoom.devices.Add(livingRoomFan);
        house1.rooms.Add(livingRoom);

        // create kitchen
        Room kitchen = new Room("kitchen");
        Lights kitchenLights = new Lights("kitchen lights", "white");
        Fan kitchenFan = new Fan("kitchen fan");

        // add kitchen devices and room to lists
        kitchen.devices.Add(kitchenLights);
        kitchen.devices.Add(kitchenFan);
        house1.rooms.Add(kitchen);

        // get start summary
        house1.GetHouseSummary();

        Thread.Sleep(5000);

        // turn on and off
        kitchenFan.SetFanSpeed(10000);
        livingRoomLights.TurnOn();
        livingRoomLights.SetColor("purple");

        // get midway summary
        house1.GetHouseSummary();
        Thread.Sleep(5000);

        // turn all on
        house1.TurnOnAll();

        // get second midway summary
        house1.GetHouseSummary();
        Thread.Sleep(5000);

        // turn all off
        house1.TurnOffAll();

        // get final summary
        house1.GetHouseSummary();
        Thread.Sleep(5000);


    }
}
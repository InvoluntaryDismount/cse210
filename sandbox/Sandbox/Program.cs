using System;

class Program
{
    static void Main(string[] args)
    {
        Device wall = new Device("bigwall");

        wall.Uptime();

        wall.TurnOn();
        Thread.Sleep(5000);
        wall.Uptime();
        Thread.Sleep(5000);
        wall.TurnOff();

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the activity!");

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine($"\nWhich activity would you like to do?");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listening");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Breathing breathing1 = new Breathing("Breathing Activity", "Help the user pace their breathing to have a session of deep breathing for a certain amount of time.");
                    breathing1.Run();
                    break;
                    
                case "2":
                    Reflection reflection1 = new Reflection();
                    break;

                case "3":
                    Listening listening1 = new Listening();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Thank you for playing, goodbye!");
                    Thread.Sleep(2000); // Wait for 2 seconds
                    Console.Clear();
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ReadLine();
                    break;

            }    
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Welcome to the activity!");

        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine($"Menu Options:");
            Console.WriteLine(" 1. Breathing");
            Console.WriteLine(" 2. Reflection");
            Console.WriteLine(" 3. Listening");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            Console.WriteLine();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Breathing breathing1 = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.Clear();
                    breathing1.Run();
                    break;
                    
                case "2":
                    Reflection reflection1 = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                    Console.Clear();
                    reflection1.Run();
                    break;

                case "3":
                    Listening listening1 = new Listening("Listening Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    Console.Clear();
                    listening1.Run();
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
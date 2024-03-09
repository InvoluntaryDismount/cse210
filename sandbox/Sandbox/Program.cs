using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Option 3");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You selected Option 1");
                    // Add logic for Option 1
                    break;

                case "2":
                    Console.WriteLine("You selected Option 2");
                    // Add logic for Option 2
                    break;

                case "3":
                    Console.WriteLine("You selected Option 3");
                    // Add logic for Option 3
                    break;

                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

            Console.WriteLine(); // Add a newline for better readability
        }
    }
}
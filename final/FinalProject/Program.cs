using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        // startup, create active (a) classes
        Profile aProfile = new Profile();
        Protein aProtein = new Protein();
        Carbs aCarbs = new Carbs();
        Fats aFats = new Fats();
        Cal aCal = new Cal();


        bool run = true;
        while(run)
        {
            Console.Clear();
            // Prompt the user to enter a numeric option
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - Update Macro");
            Console.WriteLine("2 - Create Profile");
            Console.WriteLine("3 - Load Profile");
            Console.WriteLine("4 - Save Profile");
            Console.WriteLine("5 - Quit");

            Console.WriteLine("Enter a numeric option:");
            int option = int.Parse(Console.ReadLine());
            Console.Clear();

            // Switch-case statement
            switch (option)
            {
                case 1:
                    Console.WriteLine("Update Macro");
                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine("Which macro would you like to update?");
                    Console.WriteLine("1 - Protein");
                    Console.WriteLine("2 - Fats");
                    Console.WriteLine("3 - Carbs");
                    Console.WriteLine("4 - Cal");
                    var choice = Console.ReadLine();
                    Console.Clear();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Selected Protein");
                            Thread.Sleep(1000);
                            Console.Clear();

                            aProtein.UpdateTotal();
                            aProtein.DisplayTotal();
                            Thread.Sleep(2000);

                            break;

                        case "2":
                            Console.WriteLine("Selected Fats");
                            Thread.Sleep(1000);
                            Console.Clear();
                            
                            aFats.UpdateTotal();
                            aFats.DisplayTotal();
                            Thread.Sleep(2000);
                            break;

                        case "3":
                            Console.WriteLine("Selected Carbs");
                            Thread.Sleep(1000);
                            Console.Clear();

                            aCarbs.UpdateTotal();
                            aCarbs.DisplayTotal();
                            Thread.Sleep(2000);
                            break;

                        case "4":
                            Console.WriteLine("Selected Cal");
                            Thread.Sleep(1000);
                            Console.Clear();

                            aCal.UpdateTotal();
                            aCal.DisplayTotal();
                            Thread.Sleep(2000);
                            break;
                    }

                    break;

                case 2:
                    Console.WriteLine("Create Profile");

                    Profile newProfile = new Profile();
                    newProfile.SetProfile();
                    newProfile.Save();
                    break;

                case 3:
                    Console.WriteLine("Load Profile");
                    
                    Console.WriteLine("What is the filepath of the profile you would like to load?");
                    var path = Console.ReadLine();
                    aProfile.Load(path);

                    break;

                case 4:
                    Console.WriteLine("Save Profile");

                    break;
                
                case 5:
                    Console.WriteLine("Quitting...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    run = false;
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

    }
}
using System;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {

        // startup, create active (a) classes
        Profile aProfile = new Profile();
        DailyTotal currentDT = new DailyTotal();
        
        Protein aProtein = new Protein();
        Carbs aCarbs = new Carbs();
        Fats aFats = new Fats();
        Cal aCal = new Cal();

        // add trackers to dt list
        currentDT.trackers.Add(aProtein);
        currentDT.trackers.Add(aFats);
        currentDT.trackers.Add(aCarbs);
        currentDT.trackers.Add(aCal);

        // welcome section

        Console.Clear();
        if (File.Exists("saveFolder\\userProfile.csv"))
        {
            aProfile.LoadProfile();
            currentDT.LoadDT();
            // set default goals
            aProtein.SetDefaultGoal(aProfile.GetTDEE());
            aFats.SetDefaultGoal(aProfile.GetTDEE());
            aCarbs.SetDefaultGoal(aProfile.GetTDEE());
            aCal.SetDefaultGoal(aProfile.GetTDEE());



            Console.WriteLine($"Welcome back {aProfile.GetName()}");
            Thread.Sleep(1500);
            Console.Clear();  
        }
        else
        {
            Console.WriteLine("Welcome to the daily macro tracker!");
            Thread.Sleep(2500);
            Console.Clear();

            Console.WriteLine("It looks like we do not have a profile set up for you.");
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("Lets set one up now!");
            Thread.Sleep(2500);
            Console.Clear();

            aProfile.SetProfile();

            // set default goals
            aProtein.SetDefaultGoal(aProfile.GetTDEE());
            aFats.SetDefaultGoal(aProfile.GetTDEE());
            aCarbs.SetDefaultGoal(aProfile.GetTDEE());
            aCal.SetDefaultGoal(aProfile.GetTDEE());
        }

        bool run = true;
        while(run)
        {

        // main program logic

            // go into updating macro logic / update profile option / quit
            Console.Clear();
            // Prompt the user to enter a numeric option
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - Update Macro");
            Console.WriteLine("2 - Update Profile");
            Console.WriteLine("3 - View Summary");
            Console.WriteLine("4 - Quit");

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
                    Console.WriteLine("4 - Kcal");
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
                            Console.WriteLine("Enter to continue");
                            Console.ReadLine();

                            break;

                        case "2":
                            Console.WriteLine("Selected Fats");
                            Thread.Sleep(1000);
                            Console.Clear();
                            
                            aFats.UpdateTotal();
                            aFats.DisplayTotal();
                            Console.WriteLine("Enter to continue");
                            Console.ReadLine();
                            break;

                        case "3":
                            Console.WriteLine("Selected Carbs");
                            Thread.Sleep(1000);
                            Console.Clear();

                            aCarbs.UpdateTotal();
                            aCarbs.DisplayTotal();
                            Console.WriteLine("Enter to continue");
                            Console.ReadLine();
                            break;

                        case "4":
                            Console.WriteLine("Selected Kcal");
                            Thread.Sleep(1000);
                            Console.Clear();

                            aCal.UpdateTotal();
                            aCal.DisplayTotal();
                            Console.WriteLine("Enter to continue");
                            Console.ReadLine();
                            break;
                    }
                    currentDT.UpdateTotals();
                    currentDT.SaveDT();
                    break;

                case 2:
                    Console.WriteLine("Update Profile");
                    aProfile.SetProfile();

                    // set default goals
                    aProtein.SetDefaultGoal(aProfile.GetTDEE());
                    aFats.SetDefaultGoal(aProfile.GetTDEE());
                    aCarbs.SetDefaultGoal(aProfile.GetTDEE());
                    aCal.SetDefaultGoal(aProfile.GetTDEE());

                    break;

                
                case 3:
                    // for each display method
                    foreach (Tracker t in currentDT.trackers)
                    {
                        t.DisplayTotal();
                    }
                    Console.WriteLine("Enter to continue");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Quitting...");
                    Thread.Sleep(1000);
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
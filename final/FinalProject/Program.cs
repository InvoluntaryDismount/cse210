using System;
using System.Runtime.InteropServices;
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


        

        XmlSerializer serializer = new XmlSerializer(typeof(Profile));

        // if (currentDT.GetDate() != DateOnly.FromDateTime(DateTime.Now)) {

        // }

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
                    currentDT.UpdateTotals(aProtein, aFats, aCarbs, aCal);
                    break;

                case 2:
                    Console.WriteLine("Create Profile");

                    Profile newProfile = new Profile();
                    newProfile.SetProfile();
                    aProfile = newProfile;
                    break;

                case 3:
                    Console.WriteLine("Load Profile");
                    
                    Console.WriteLine("What is the name of the profile you would like to load?");
                    var loadName = Console.ReadLine();
                    using (TextReader reader = new StreamReader($"profiles\\{loadName}.xml"))
                    {
                        aProfile = (Profile)serializer.Deserialize(reader);
                    }

                    break;

                case 4:
                    Console.WriteLine("Save Profile");

                    using (TextWriter writer = new StreamWriter($"profiles\\{aProfile.GetName()}.xml"))
                    {
                        serializer.Serialize(writer, aProfile);
                    }
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
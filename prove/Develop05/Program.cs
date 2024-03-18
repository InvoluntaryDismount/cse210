using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool running = true;

        Score CurrentScore = new Score();
        Handler MainHandle = new Handler("Goals.txt");

        while (running)
        {
            Console.Clear();
            Console.WriteLine($"You have {CurrentScore.GetPointTotal()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Creating new goal...");
                    Thread.Sleep(1000);

                    // Display goal options
                    Console.Clear();
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which Goal would you like to create?");
                    string response = Console.ReadLine();

                    switch (response)
                    {
                        case "1":
                            Console.WriteLine("Simple Goal selected");

                            // get args
                            Console.WriteLine("What is the name of your goal? ");
                            string simpName = Console.ReadLine();
                            Console.WriteLine("What is a short description of it? ");
                            string simpDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal? ");
                            int simpGoalPoints = int.Parse(Console.ReadLine());

                            // create object and add to handler list
                            Goal simpGoal = new Goal(simpName, simpDescription, simpGoalPoints);
                            MainHandle.AddGoal(simpGoal);

                            break;
                        case "2":
                            Console.WriteLine("Eternal Goal selected");

                            // get args
                            Console.WriteLine("What is the name of your goal? ");
                            string etName = Console.ReadLine();
                            Console.WriteLine("What is a short description of it? ");
                            string etDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal? ");
                            int etGoalPoints = int.Parse(Console.ReadLine());

                            // create object and add to handler list
                            Goal etGoal = new Goal(etName, etDescription, etGoalPoints);
                            MainHandle.AddGoal(etGoal);
                            break;
                        case "3":
                            Console.WriteLine("Checklist Goal selected");

                            // get args
                            Console.WriteLine("What is the name of your goal? ");
                            string checkName = Console.ReadLine();
                            Console.WriteLine("What is a short description of it? ");
                            string checkDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal? ");
                            int checkGoalPoints = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many times would you like to complete this goal? ");
                            int checkTarget = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many bonus points would you like when you complete this goal? ");
                            int checkBonus = int.Parse(Console.ReadLine());

                            // create object and add to handler list
                            Checklist checkGoal = new Checklist(checkName, checkDescription, checkGoalPoints, checkTarget, checkBonus);
                            MainHandle.AddGoal(checkGoal);
                            break;
                        default:
                            Console.WriteLine("Invalid option selected");
                            Thread.Sleep(1000);
                            break;
                    }                
                    break;

                case "2":
                    Console.WriteLine("Listing goals...");
                    Thread.Sleep(1000);
                    
                    // Add code to handle listing goals
                    MainHandle.DisplayGoals();
                    Console.WriteLine("Hit 'enter' to continue");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("Saving goals...");
                    // Add code to handle saving goals
                    MainHandle.Save();
                    Console.WriteLine("Goals successfully saved");
                    Thread.Sleep(2000);
                    break;

                case "4":
                    Console.WriteLine("Loading goals...");
                    // Add code to handle loading goals
                    MainHandle.Load();
                    Console.WriteLine("Goals successfully loaded");
                    Thread.Sleep(2000);
                    break;

                case "5":
                    Console.WriteLine("Recording event...");
                    // Add code to handle recording an event
                    // Ask which goal was accomplished
                    Console.WriteLine("Which goal did you accomplish?");
                    var index = 1;
                    foreach (var goal in MainHandle._goals)
                    {
                        Console.WriteLine($"{index}. {goal.GetName()}");
                        index++;
                    }

                    var input = int.Parse(Console.ReadLine());
                    
                    // update that goal
                    MainHandle._goals[input-1].UpdateGoal(CurrentScore);
                    Thread.Sleep(500);
                    break;

                case "6":
                    Console.WriteLine("Quitting...");
                    running = false;
                    Thread.Sleep(500);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
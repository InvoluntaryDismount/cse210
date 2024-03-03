class Listening : Activity {
        
    static private List<string> prompts = 
    [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    public Listening(string name, string description)
    {
        _name = name;
        _activityDescription = description;
        _duration = 5;
    }

    private static void Prompt()
    {
        var random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
    }

    
    public override void Run()
    {
        base.PrintIntroduction();
        Thread.Sleep(7000);
        Console.Clear();
        _duration = GetDuration();  
        Prompt();
        for (int j = 3; j > 0; j--)
        {    
            Console.Write($"Start in... {j}      "); // Use spaces to clear the remaining characters
            Thread.Sleep(1000); // Sleep for 1 second
            Console.Write('\r'); // Move cursor to the beginning of the line
        }
        Console.WriteLine("Enter responses: ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();

            itemCount++;
        }
        Console.WriteLine($"You wrote {itemCount} entries");
        
        PrintEndMessage();
        


    }
}
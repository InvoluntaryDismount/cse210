class Breathing : Activity {

    // create constructor
    public Breathing(string name, string description)
    {
        _name = name;
        _activityDescription = description;
        _duration = 5;
    }

    private void Breathe(int duration)
    {
        for (int i = 0; i < _duration/10; i++)
        {
            for (int j = 4; j > 0; j--)
            {    
                {
                    Console.Write($"Breathe in... {j}      "); // Use spaces to clear the remaining characters
                    Thread.Sleep(1000); // Sleep for 1 second
                    Console.Write('\r'); // Move cursor to the beginning of the line
                }
            }

            for (int j = 6; j > 0; j--)
            {    
                {
                    Console.Write($"Now breathe out... {j}      "); // Use spaces to clear the remaining characters
                    Thread.Sleep(1000); // Sleep for 1 second
                    Console.Write('\r'); // Move cursor to the beginning of the line
                }
            }
        }
    }

    public override void Run()
    {
        base.PrintIntroduction();
        _duration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        Breathe(_duration);
        PrintEndMessage();
    }
}
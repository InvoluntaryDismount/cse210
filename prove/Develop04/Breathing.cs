class Breathing : Activity {

    // create constructor
    public Breathing(string name, string description)
    {
        _name = name;
        _activityDescription = description;
        _duration = 5;
    }

    private void Breathe()
    {
        Console.WriteLine("Breathe in");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine("Breathe in.");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine("Breathe in..");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine("Breathe in...");
        Thread.Sleep(500);
        Console.Clear();

        Console.WriteLine("Breathe out");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine("Breathe out.");
        Thread.Sleep(500);
        Console.Clear();
        
        Console.WriteLine("Breathe out..");
        Thread.Sleep(500);
        Console.Clear();        

        Console.WriteLine("Breathe out...");
        Thread.Sleep(500);
        Console.Clear();
            
    }

    public override void Run()
    {
        base.PrintIntroduction();
        Thread.Sleep(200);
        Console.Clear();
        Breathe();

    }
}
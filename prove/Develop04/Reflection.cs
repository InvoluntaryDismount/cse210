class Reflection : Activity {
    static private List<string> prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "What is one thing I worked on improving today?"];
    static private List<string> questions = [
        "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    ];

    // create constructor
    public Reflection(string name, string description)
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

    private static void Question()
    {
        var random = new Random();
        int index = random.Next(questions.Count);
        Console.WriteLine(questions[index]);
    }

    private void Cycle()
    {
        Reflection.Prompt();
        Reflection.Question();
        base.Spinner(10);
    }


    public override void Run()
    {
        base.PrintIntroduction();
        _duration = GetDuration();

        for (int i = 0; i < _duration/10; i++)
        {
            Cycle();
        }
        PrintEndMessage();
    }
}
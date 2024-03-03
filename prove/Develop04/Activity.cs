abstract class Activity() {
    protected string _name;
    protected string _activityDescription;

    protected static int _duration;

    public abstract void Run();

    public void PrintIntroduction() {
        Console.WriteLine($"\nWelcome to {_name}\n\n{_activityDescription}");
    }

    public static int GetDuration() {
        Console.WriteLine($"\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        return duration;
    }
    public void PrintEndMessage() {
        Console.WriteLine($"Congratutlations! You have completed {_name}\nLength of Time: {_duration}");
        Thread.Sleep(5000);
    }

    public void Spinner(int loadTime) {
        for (int i = 0; i < loadTime; i++) {
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character
            
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character
        }
    }
}
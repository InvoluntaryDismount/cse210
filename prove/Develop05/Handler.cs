public class Handler
{
    public List<Goal> _goals = new List<Goal>();
    private string _filepath;

    // create constructor
    public Handler(string filepath)
    {
        _filepath = filepath;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    
    private void SetFilePath(string filepath)
    {
        _filepath = filepath;
    }
    
    private string GetFilePath()
    {
        return _filepath;
    }

    public void DisplayGoals()
    {
        var index = 1;
        foreach (var goal in _goals)
        {
            Console.Write($"{index}. ");
            goal.DisplayGoal();
            Console.WriteLine();
            index++;
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the filename for the loading file? ");
        string path = Console.ReadLine();
        SetFilePath(path);
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(_filepath);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 4)
            {
                string name = parts[0];
                string desc = parts[1];
                int value = int.Parse(parts[2]);
                bool isDone = bool.Parse(parts[3]);

                Goal goal = new Goal(name, desc, value, isDone);
                _goals.Add(goal);

            }
            else if (parts.Length == 7)
            {
                string name = parts[0];
                string desc = parts[1];
                int value = int.Parse(parts[2]);
                bool isDone = bool.Parse(parts[3]);
                int completed = int.Parse(parts[5]);
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[6]);

                Checklist goal = new Checklist(name, desc, value, isDone, completed, target, bonus);
                _goals.Add(goal);

            }
            else
            {
                Console.WriteLine("Error loading goal");
                Thread.Sleep(3000);
            }
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string path = Console.ReadLine();
        SetFilePath(path);

        using (StreamWriter outputFile = new StreamWriter(_filepath))
        {
            foreach (Goal goal in _goals)
            {
                string summary = goal.Summarise();
                outputFile.WriteLine(summary);
            }
        }
    }
}
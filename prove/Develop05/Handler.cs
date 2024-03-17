public class Handler
{
    private List<Goal> _goals = new List<Goal>();
    private string _filepath;
    
    public void SetFilePath(string filepath)
    {
        _filepath = filepath;
    }
    
    public string GetFilePath()
    {
        return _filepath;
    }

    public void DisplayGoals()
    {
        var index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}. ");
            goal.DisplayGoal();
            index++;
        }
    }

    public void Load()
    {

    }

    public void Save()
    {
        
    }
}
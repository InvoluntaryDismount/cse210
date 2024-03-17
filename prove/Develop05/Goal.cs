public abstract class Goal 
{
    private string _goalName;
    private string _goalDescription;
    private int _pointValue;
    private bool _isDone;

    public Goal(string name, string desc, int value)
    {
        _goalName = name;
        _goalDescription = desc;
        _pointValue = value;
    }

    public abstract void Run();

    public void SetName(string name)
    {
        _goalName = name;
    }

    public string GetName()
    {
        return _goalName;
    }

    public void SetDescription(string description)
    {
        _goalDescription = description;
    }

    public string GetDescription()
    {
        return _goalDescription;
    }

    public void SetValue(int value)
    {
        _pointValue = value;
    }
    
    public virtual void DisplayGoal()
    {
        if (_isDone == true)
        {
            Console.Write($"[X] {_goalName} ({_goalDescription})");
        }
        else
        {
            Console.Write($"[ ] {_goalName} ({_goalDescription})");
        }
    }

}
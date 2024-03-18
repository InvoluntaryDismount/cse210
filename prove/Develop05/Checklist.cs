class Checklist : Goal
{
    private int _completed;
    private int _compTarget;
    private int _bonus;

    public Checklist(string name, string desc, int value, int target, int bonus) : base(name, desc, value)
    {
        _completed = 0;
        _compTarget = target;
        _bonus = bonus;
    }
    public Checklist(string name, string desc, int value, bool isDone, int completed, int target, int bonus) : base(name, desc, value, isDone)
    {
        _completed = 0;
        _compTarget = target;
        _bonus = bonus;
    }

    private int GetCompleted()
    {
        return _completed;
    }

    private int GetTarget()
    {
        return _compTarget;
    }

    private int GetBonus()
    {
        return _bonus;
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
        Console.Write($" -- Currently completed: {_completed}/{_compTarget}");
    }

    public override string Summarise()
    {
        string summary = $"{GetName()}|{GetDescription()}|{GetValue()}|{GetIsDone()}|{GetCompleted()}|{GetTarget()}|{GetBonus()}";
        return summary;
    }

    public override void UpdateGoal(Score score)
    {
        score.AddScore(base._pointValue);
        _completed++;
        if (_completed == _compTarget)
        {
            base._isDone = true;
            score.AddScore(_bonus);
        }

    }
}
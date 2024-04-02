[Serializable]
public abstract class Tracker {
    protected string _type;
    protected int _total;
    protected int _goal;

    public Tracker()
    {
        _total = 0;
        _goal = 1000;
    }

    public virtual void UpdateTotal() {
        Console.Write($"How much would you like to add to {_type}(g)? ");
        var input = int.Parse(Console.ReadLine());
        _total = _total + input;
        if (_total >= _goal) {
            Console.WriteLine($"Congratulations! You hit your goal of {_goal}");
        }
    }

    public string GetName() {
        return _type;
    }

    public int GetTotal() {
        return _total;
    }

    public void SetTotal(int total) {
        _total = total;
    }

    public int GetGoal() {
        return _goal;
    }

    public void SetGoal(int goal) {
        _goal = goal;
    }

    public void DisplayTotal() {
        Console.WriteLine($"You have consumed {_total}g of {_type}");
    }

    public abstract double CalcMacroGoal(double tdee);

}
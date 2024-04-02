[Serializable]
public abstract class Tracker {
    protected string _name;
    protected int _total;
    protected int _input;
    protected int _goal;
    protected DateOnly _inputDate;

    public Tracker()
    {
        _total = 0;
    }

    public virtual void UpdateTotal() {
        Console.Write($"How much would you like to add to {_name}(g)? ");
        _input = int.Parse(Console.ReadLine());
        _inputDate = DateOnly.FromDateTime(DateTime.Now);
        _total = _total + _input;
    }

    public string GetName() {
        return _name;
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
        Console.WriteLine($"You have consumed {_total}g of {_name}");
    }

    public abstract double CalcMacroGoal(double tdee);

}
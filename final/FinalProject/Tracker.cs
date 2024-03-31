public abstract class Tracker {
    private string _name;
    private int _total;
    private int _input;
    private int _goal;
    private DateTime _inputTime;


    private void UpdateTotal() {
        Console.Write($"How much would you like to add to {_name}? ");
        _input = int.Parse(Console.ReadLine());
        _inputTime = DateTime.Now;
        _total = _total + _input;
    }

    private int GetTotal() {
        return _total;
    }

    private void SetTotal(int total) {
        _total = total;
    }

    private int GetGoal() {
        return _goal;
    }

    private void SetGoal(int goal) {
        _goal = goal;
    }

    public void DisplayTotal() {
        Console.WriteLine($"You have consumed {_total}g of {_name}");
    }

    public abstract void CalcMacroGoal();

}
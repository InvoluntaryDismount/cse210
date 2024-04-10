[Serializable]
public class Cal : Tracker {

        public Cal()
    {
        _type = "kcal";
    }
    public override double CalcMacroGoal(double tdee) {
        return tdee;
    }
    public override void UpdateTotal() {
        Console.Write($"How much would you like to add to {_type}? ");
        var input = int.Parse(Console.ReadLine());
        _total = _total + input;
        if (_total >= _goal) {
            Console.WriteLine($"Congratulations! You hit your goal of {_goal}");
        }
    }
    public override void DisplayTotal() {
        Console.WriteLine($"You have consumed {_total} out of {_goal} target {_type}");
    }
}
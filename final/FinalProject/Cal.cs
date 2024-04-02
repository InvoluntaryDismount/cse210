[Serializable]
public class Cal : Tracker {

        public Cal()
    {
        _type = "cal";
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
}
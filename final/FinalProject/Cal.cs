[Serializable]
public class Cal : Tracker {

        public Cal()
    {
        _name = "Cal";
    }
    public override double CalcMacroGoal(double tdee) {
        return tdee;
    }
        public override void UpdateTotal() {
        Console.Write($"How much would you like to add to {_name}? ");
        _input = int.Parse(Console.ReadLine());
        _inputDate = DateOnly.FromDateTime(DateTime.Now);
        _total = _total + _input;
    }
}
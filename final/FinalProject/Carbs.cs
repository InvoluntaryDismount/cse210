public class Carbs : Tracker {
    public override double CalcMacroGoal(double tdee) {
        return tdee * 0.4 / 4;
    }
}
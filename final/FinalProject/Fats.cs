public class Fats : Tracker {
    public override double CalcMacroGoal(double tdee) {
        return tdee * 0.3 / 9;
    }
}
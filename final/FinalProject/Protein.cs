public class Protein : Tracker {
    public override double CalcMacroGoal(double tdee) {
        return tdee * 0.3 / 4;
    }
}
[Serializable]
public class Protein : Tracker {

    public Protein()
    {
        _name = "protein";
    }
    public override double CalcMacroGoal(double tdee) {
        return tdee * 0.3 / 4;
    }
}
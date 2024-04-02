[Serializable]
public class Protein : Tracker {

    public Protein()
    {
        _type = "protein";
    }
    public override double CalcMacroGoal(double tdee) {
        return tdee * 0.3 / 4;
    }
}
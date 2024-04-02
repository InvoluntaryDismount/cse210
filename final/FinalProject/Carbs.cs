[Serializable]
public class Carbs : Tracker {

        public Carbs()
    {
        _name = "Carbs";
    }
    public override double CalcMacroGoal(double tdee) {
        return tdee * 0.4 / 4;
    }
}
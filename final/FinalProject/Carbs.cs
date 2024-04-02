[Serializable]
public class Carbs : Tracker {

        public Carbs()
    {
        _type = "carbs";
    }
    public override double CalcMacroGoal(double tdee) {
        return tdee * 0.4 / 4;
    }
}
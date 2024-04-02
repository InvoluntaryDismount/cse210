[Serializable]
public class Fats : Tracker {

        public Fats()
    {
        _name = "Fats";
    }
    public override double CalcMacroGoal(double tdee) {
        return tdee * 0.3 / 9;
    }
}
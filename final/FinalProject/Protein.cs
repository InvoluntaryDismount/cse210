[Serializable]
public class Protein : Tracker {

    public Protein()
    {
        _type = "protein";
        _goal = 0;
    }

    public int CalcMacroGoal(double tdee)
    {
        return Convert.ToInt32(tdee * 0.3 / 4);
    }

    public void SetDefaultGoal(double tdee)
    {
        _goal = CalcMacroGoal(tdee);
    }
}
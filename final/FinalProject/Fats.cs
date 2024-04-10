[Serializable]
public class Fats : Tracker {

    public Fats()
    {
        _type = "fats";
        _goal = 0;
    }

    public int CalcMacroGoal(double tdee)
    {
        return Convert.ToInt32(tdee * 0.3 / 9);
    }

    public void SetDefaultGoal(double tdee)
    {
        _goal = CalcMacroGoal(tdee);
    }
}
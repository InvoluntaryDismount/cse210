[Serializable]
public class Carbs : Tracker {

    public Carbs()
    {
        _type = "carbs";
        _goal = 0;
    }

    public int CalcMacroGoal(double tdee)
    {
        return Convert.ToInt32(tdee * 0.4 / 4);
    }
    
    public void SetDefaultGoal(double tdee)
    {
        _goal = CalcMacroGoal(tdee);
    }
}
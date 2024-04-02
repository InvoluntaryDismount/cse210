# Meal Tracker

### Blake Christensen

## Classes

public class Tracker
Attributes:
private string _name
private int _total
private int _input
private int _goal
private datetime _inputTime
Methods:
private void UpdateTotal()
private int GetTotal()
private void SetTotal()
private int GetGoal()
private void SetGoal()
public void DisplayTotal()
public abstract CalcMacroGoal()


public class Protein : Tracker
Methods:
public override CalcMacrogoal()

public class Fats : Tracker
Methods:
public override CalcMacrogoal()

public class Carbs : Tracker
Methods:
public override CalcMacrogoal()

public class Cal : Tracker
Methods:
public override CalcMacrogoal()


public class DailyTotal
Attributes:
private date _date
private int _totalProtein
private int _totalFats
private int _totalCarbs
private int _totalCal
Methods:
public void GetterForEach()
public void SetterForEach()


public class Handler
Attributes:
private datetime _startTime
private string _filePath
private list<DailyTotal> _totals
private list<Profile> _profiles
Methods:
private int CalcWeekAvg()
public void DisplayAvg()


public class Profile
Attributes:
private string _name
private string _gender
private int _weightKg
private int _heightCm
private int _age
private int _activityLevel
private int _TDEE
Methods:
public int CalcBMR()
    For men: BMR = 88.362 + (13.397 × weight in kg) + (4.799 × height in cm) - (5.677 × age in years)
    For women: BMR = 447.593 + (9.247 × weight in kg) + (3.098 × height in cm) - (4.330 × age in years)
public int Calc(TDEE)
    TDEE = BMR × Activity Multiplier
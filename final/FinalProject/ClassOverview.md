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
private datetime _startTime
private string _filePath
private list<DailyTotal> _totals

private int CalcWeekAvg()
public void DisplayAvg()
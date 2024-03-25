# Macro Tracker
### Blake Christesen

## Objective
The goal is to make a simple program that tracks daily macro intake (protein, fats, carbs) as well as caloric intake. The program will record the daily intakes and keep a record that can be accessed by the user. The user will have the option to ask the program what their recommended daily intake is for each macro and the program will return a value based off the user's answer to health related questions. The user will also have the option to view weekly summaries.

## Notes
### GUI
Potential GUI could be done with Xamarin.Forms

### Classes


// input time will keep track of when the macro was last updated and if it is a new day the tracker will save the final total for the day to the main json (or whatever it is that saves). That or when the program boots up it will check the time

public class Tracker
Attributes:
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
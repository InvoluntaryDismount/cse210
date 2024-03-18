# Macro Tracker
### Blake Christesen

## Objective
The goal is to make a simple program that tracks daily macro intake (protein, fats, carbs) as well as caloric intake. The program will record the daily intakes and keep a record that can be accessed by the user. The program will be interacted with through a simple graphical interface.

## Notes
### GUI
Potential GUI could be done with Xamarin.Forms

### Classes


// input time will keep track of when the macro was last updated and if it is a new day the tracker will save the final total for the day to the main json (or whatever it is that saves). That or when the program boots up it will check the time
Tracker <-- will have one for each macro/cal
private int _total
private int _input
private int _goal
private datetime _inputTime

private void UpdateTotal()
private int GetTotal()
private void SetTotal()
private int GetGoal()
private void SetGoal()
public abstract CalcGoalMac() -- take in user input to figure out a solid baseline for macro



DailyTotal
private date _date
private int _totalProtein
private int _totalFats
private int _totalCarbs
private int _totalCal

public void GetterForEach()
public void SetterForEach()



Handler
private datetime _startTime
private string _filePath
private list<DailyTotal> _totals

private _____ CalcAvg()
public void DisplayAvg()
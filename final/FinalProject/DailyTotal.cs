public class DailyTotal{

    private DateOnly _date;
    private int _totalProtein;
    private int _totalFats;
    private int _totalCarbs;
    private int _totalCal;

    public DailyTotal()
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
    }

    public void SetDate(DateOnly date)
    {
        _date = date;
    }

    public void UpdateTotals(Tracker protein, Tracker fats, Tracker carbs, Tracker cal)
    {
        _totalProtein = protein.GetTotal();
        _totalFats = fats.GetTotal();
        _totalCarbs = carbs.GetTotal();
        _totalCal = cal.GetTotal();
    }

    public void CheckDate()
    {
        if (_date != DateOnly.FromDateTime(DateTime.Now))
        {
         // save function and open instantiate a new DailyTotal
         Console.WriteLine("New day detected. Creating new DailyTotal");   
        }
    }
}
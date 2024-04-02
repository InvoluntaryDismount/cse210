public class DailyTotal{

    private DateOnly _date;
    private int _totalProtein;
    private int _totalFats;
    private int _totalCarbs;
    private int _totalCal;
    private List<int> _totals = new List<int>(4);
    public const int proteinIndex = 0;
    public const int fatsIndex = 1;
    public const int carbsIndex = 2;
    public const int calIndex = 3;
    Dictionary<DateOnly, DailyTotal> dailyTotals = new Dictionary<DateOnly, DailyTotal>();
    

    public DailyTotal()
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
    }

    public DateOnly GetDate()
    {
        return _date;
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
        public void CheckDay()
    {
        if (_date() != DateOnly.FromDateTime(DateTime.Now))
        {
            dailyTotals.Add(_date(),_totals);
        }
    }

}
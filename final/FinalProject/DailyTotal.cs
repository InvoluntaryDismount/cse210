[Serializable]
public class DailyTotal{

    private DateOnly _date;
    private List<int> _totals = new List<int>(4);
    public List<Tracker> trackers = new List<Tracker>();
    public const int proteinIndex = 0;
    public const int fatsIndex = 1;
    public const int carbsIndex = 2;
    public const int calIndex = 3;
    Dictionary<DateOnly, List<int>> dailyTotals = new Dictionary<DateOnly, List<int>>();
    

    public DailyTotal()
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _totals = new List<int> {0,0,0,0};

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
        _totals[proteinIndex] = protein.GetTotal();
        _totals[fatsIndex] = fats.GetTotal();
        _totals[carbsIndex] = carbs.GetTotal();
        _totals[calIndex] = cal.GetTotal();
    }
        public void CheckDay()
    {
        if (_date != DateOnly.FromDateTime(DateTime.Now))
        {
            dailyTotals[_date] = _totals;
            _date = DateOnly.FromDateTime(DateTime.Now);
            _totals = new List<int> {0,0,0,0};
        }
    }

}
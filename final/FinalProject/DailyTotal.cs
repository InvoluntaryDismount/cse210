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

    public void UpdateTotals()
    {
        for (int i = 0; i < 4; i++)
        {
            _totals[i] = trackers[i].GetTotal();
        }        
    }

    public void CheckDtTotals()
    {
        foreach (int n in _totals)
        {
            Console.WriteLine(n);
        }
    }

        public void CheckDay()
    {
        if (_date != DateOnly.FromDateTime(DateTime.Now))
        {
            dailyTotals[_date] = _totals;
            _date = DateOnly.FromDateTime(DateTime.Now);
            _totals = new List<int> {0,0,0,0};

            // reset trackers
            foreach (Tracker t in trackers)
            {
                t.SetTotal(0);
            }
        }
    }
    public void SaveDT(DailyTotal dt)
    {

    }

}
[Serializable]
public class DailyTotal{

    private DateOnly _date;
    private List<int> _totals = new List<int>(4);
    public List<Tracker> trackers = new List<Tracker>();
    public const int proteinIndex = 0;
    public const int fatsIndex = 1;
    public const int carbsIndex = 2;
    public const int calIndex = 3;
    private Dictionary<DateOnly, List<int>> _dailyTotals = new Dictionary<DateOnly, List<int>>();
    

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
    public void TotalsDictUpdate()
    {
        _dailyTotals[_date] = _totals;
    }

        public void CheckDay()
    {
        if (_date != DateOnly.FromDateTime(DateTime.Now))
        {
            TotalsDictUpdate();
            _date = DateOnly.FromDateTime(DateTime.Now);
            _totals = new List<int> {0,0,0,0};

            // reset trackers
            foreach (Tracker t in trackers)
            {
                t.SetTotal(0);
            }
        }
    }
    public void SaveDT()
    {
        // save to csv
    }
    public void LoadDT()
    {
        // read in from csv
        // check dailyTotals for value at current date and if so grab list of totals
        // set tracker totals to what is in the list
    }

}
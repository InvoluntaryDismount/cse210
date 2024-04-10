using System.Text;

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
        TotalsDictUpdate();
        string filePath = "saveFolder\\userDT.csv";
        // overrite old data
        using (StreamWriter writer = new StreamWriter(filePath, false))
        {
            foreach(var kvp in _dailyTotals)
            {
                string dtString = $"{kvp.Key}|{kvp.Value[0]}|{kvp.Value[1]}|{kvp.Value[2]}|{kvp.Value[3]}\n";
                writer.Write(dtString);
            }
        }

    }

    
    public void LoadDT()
    {
        string filePath = "saveFolder\\userDT.csv";

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("The CSV file does not exist.");
            return;
        }
        else
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split('|');

                    // load fields into _dailyTotals dictionary
                    string d = fields[0].ToString();
                    DateOnly date = DateOnly.ParseExact(d, "M/d/yyyy", null);

                    string p = fields[1].ToString();
                    int protein = int.Parse(p);

                    string f = fields[2].ToString();
                    int fats = int.Parse(f);

                    string car = fields[3].ToString();
                    int carbs = int.Parse(car);

                    string cal = fields[4].ToString();
                    int kcal = int.Parse(cal);

                    _dailyTotals[date] = new List<int>{protein,fats,carbs,kcal};
                }
            }

            // update daily totals to be the dictionary values from today
            _totals = _dailyTotals[DateOnly.FromDateTime(DateTime.Now)];
            
            // update trackers to be accurate
            for (int i = 0; i < 4; i++)
            {
                trackers[i].SetTotal(_totals[i]);
            }

        }
    }
}
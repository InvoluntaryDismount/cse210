TO DO:

    update trackers after load

    complete CalcMacroGoal function in Tracker

    Write setGoal functions for each tracker subclass. 
    """
    It is recommended you consume ... of ...
    What would you like your goal to be?

    """



Notes:

figure out how to add trackers to dailytotal and dailytotal to profile


Blake
M
80
194
21
3

Ethan
M
79.337
178
16
4

    private DateOnly _date;
    
    private List<int> _totals = new List<int>(4);

    public List<Tracker> trackers = new List<Tracker>();

    private Dictionary<DateOnly, List<int>> _dailyTotals = new Dictionary<DateOnly, List<int>>();
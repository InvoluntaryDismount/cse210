TO DO:


    4 ints with set index in the list. One for each tracker.

    Save/Load dt to csv

    Write setGoal functions for each tracker subclass. 
    """
    It is recommended you consume ... of ...
    What would you like your goal to be?

    """

    complete CalcMacroGoal function in Tracker


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
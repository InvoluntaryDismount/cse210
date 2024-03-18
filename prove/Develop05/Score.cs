public class Score
{
    private int _pointTotal;

    public Score()
    {
        _pointTotal = 0;
    }

    public int GetPointTotal()
    {
        return _pointTotal;
    }

    public void DisplayTotal()
    {
        Console.WriteLine($"You have {_pointTotal} points");
    }

    public void AddScore(int addValue)
    {
        _pointTotal = _pointTotal + addValue;
    }
}
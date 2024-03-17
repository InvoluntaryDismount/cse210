public class Score
{
    private int _pointTotal;

    public void DisplayTotal()
    {
        Console.WriteLine($"You have {_pointTotal} points");
    }

    public void AddScore(int addValue)
    {
        _pointTotal = _pointTotal + addValue;
    }
}
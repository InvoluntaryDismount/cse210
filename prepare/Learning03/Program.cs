using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction blank = new Fraction();
        Fraction wholeNum = new Fraction(5);
        Fraction both = new Fraction(3, 4);
        
        Console.WriteLine($"{blank.GetFractionString()} {blank.GetDecimalValue()}");
        Console.WriteLine($"{wholeNum.GetFractionString()} {wholeNum.GetDecimalValue()}");
        Console.WriteLine($"{both.GetFractionString()} {both.GetDecimalValue()}");
    }
}
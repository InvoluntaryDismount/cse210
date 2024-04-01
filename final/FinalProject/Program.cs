using System;

class Program
{
    static void Main(string[] args)
    {
        Profile P = new Profile();
        P.SetProfile();

        Console.WriteLine($"BMR: {P.GetBmr()} TDEE: {P.GetTDEE()}");

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -9;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        do
        {
        Console.Write("What is the magic number? ");
        guess = int.Parse(Console.ReadLine());
        if (guess > number)
            Console.WriteLine("Lower");
        if (guess < number)
            Console.WriteLine("Higher");
        } while (guess != number);

        Console.WriteLine("You guessed it!");




    }
}
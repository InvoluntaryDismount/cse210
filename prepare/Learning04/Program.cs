using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment Frank = new Assignment("Frank Borris", "Math");
        Frank.GetSummary();

        Console.WriteLine();

        MathAssignment Gary = new MathAssignment("Gary Oak", "Math", "7.3", "1-20");
        Gary.GetSummary();
        Gary.GetHomeworkList();

        Console.WriteLine();

        WritingAssignment Harry = new WritingAssignment("Harry Potter", "English", "The Sorcerer's Stone");
        Harry.GetSummary();
        Harry.GetWrittingInformation();
    }
}
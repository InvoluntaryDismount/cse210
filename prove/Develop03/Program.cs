using System;

class Program
{
    static void Main(string[] args)
    {
        // prep
        ScriptureReference r1 = new ScriptureReference("Revelation", 5, 6, "And I beheld, and, lo, in the midst of the throne and of the four beasts, and in the midst of the elders, stood a Lamb as it had been slain, having seven horns and seven eyes, which are the seven Spirits of God sent forth into all the earth.");
        bool run = true;
        while (run) {
            Console.Clear();
            r1.DisplayVerse();
            Console.WriteLine($"\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            var input = Console.ReadLine();
            if (input == "quit"){
                break;
            }
            else {
                for (int i = 0; i < 3; i++)
                if (r1.s1.shownIndexes.Count() > 0) {
                    r1.s1.HideWords();
                }
                else {
                    break;
                }
            }
        }
    }
}
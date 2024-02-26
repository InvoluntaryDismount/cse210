using System;
using System.Collections;
using System.IO.Enumeration;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        Journal currentJournal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!\nPlease selet one of the following choices:");

        while (exit!=true) {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    Console.WriteLine("You have selected: Write");
                    string currentPrompt = Prompter.PromptRandom();
                    string response = Console.ReadLine();
                    string date = Entry.GetDate();
                    Entry currentEntry = new Entry(date, currentPrompt, response);
                    currentJournal.AddEntry(currentEntry);
                    break;
            }

            switch (choice) {
                case "2":
                    Console.WriteLine("You have selected: Display");
                    currentJournal.DisplayJournal();
                    break;
            }

            switch (choice) {
                case "3":
                    // dump the old journal
                    currentJournal.entries.Clear();

                    Console.WriteLine($"You have selected: Load");
                    Console.WriteLine("What is the name of the file?");
                    string readFile = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(readFile);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");
                        
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        Entry currentEntry = new Entry(date, prompt, response);
                        currentJournal.AddEntry(currentEntry);
                    }
                    
                    break;
            }

            switch (choice) {
                case "4":
                    Console.WriteLine("You have selected: Save");
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    currentJournal.WriteJournal(filename);
                    break;
            }

            switch (choice) {
                case "5":
                    exit = true;
                    break;
            }
        }
    }
}
using System;

public class Prompter {
    static private List<string> prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What is one thing I worked on improving today?", "If I had one thing I could do over today, what would it be?", "How have I helped others today?"];

    static public string PromptRandom() {
        var random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
        return prompts[index];
    }
}
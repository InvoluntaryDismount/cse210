using System;

public class Prompter {
    static private List<string> prompts = ["Prompt1", "Prompt2", "Prompt3"];

    static public void PromptRandom() {
        var random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
    }
}
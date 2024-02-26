using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

public class Entry {
    public List<string> prompts = new List<string>();

    public List<string> responses = new List<string>();
    public List<string> dates = new List<string>();

    public string date;

    public Entry() {
        date = Entry.GetDate();
    }

    private static string GetDate() {
        DateTime currentDate = DateTime.Now;
        return currentDate.ToShortDateString();
    }

    public void SaveEntry(string prompt, string response) {
        prompts.Add(prompt);
        responses.Add(response);
        dates.Add(date);
    }

    public void DisplayEntries() {
        for (int i = 0; i < prompts.Count(); i++) {
            Console.WriteLine($"Date: {date} - Prompt: {prompts[i]}\n{responses[i]}");
        }
    }
}

    
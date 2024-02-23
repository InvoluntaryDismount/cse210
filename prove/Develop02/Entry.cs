using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

public class Entry {
    public List<string> prompts = new List<string>();

    public List<string> responses = new List<string>();

    public string date;

    public Entry() {
        GetDate();
    }

    private void GetDate() {
        DateTime currentTime = DateTime.Now;
        date = currentTime.ToShortTimeString();
    }

    public void SaveEntry(string prompt, string response) {
        prompts.Add(prompt);
        responses.Add(response);
    }

    public void DisplayEntries() {
        for (int i = 0; i < prompts.Count(); i++) {
            Console.WriteLine($"Date: {date} - Prompt: {prompts[i]}\n{responses[i]}");
        }
    }
}

    
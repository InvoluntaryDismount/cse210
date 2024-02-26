using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

public class Entry {
    public string prompt;

    public string response;

    public string date;

// constructor
    public Entry(string date, string prompt, string response) {
        this.date = date;
        this.prompt = prompt;
        this.response = response;
    }

    public static string GetDate() {
        DateTime currentDate = DateTime.Now;
        return currentDate.ToShortDateString();
    }

    public void DisplayEntry() {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}\n{response}\n");
    }
}

    
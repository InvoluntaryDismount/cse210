// 

using System.Data;
using System.Globalization;

public class ScriptureReference {
    private string book;
    private int chapter;
    private int verse;
    public Scripture s1;




    public ScriptureReference(string book, int chapter, int verse, string text) {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        s1 = new Scripture(text);
    }

    public void DisplayVerse() {
        Console.WriteLine($"{book} {chapter}: {verse} ");
        foreach (Word w in s1.WordsList)
        {
            w.DisplayWord();
        }
    }
}
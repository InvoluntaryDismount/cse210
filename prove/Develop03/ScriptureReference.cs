// 

using System.Data;
using System.Globalization;

public class ScriptureReference {
    private string book;
    private int chapter;
    private string verse;
    private Scripture text;




    public ScriptureReference(string book, int chapter, string verse, string text) {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.text = new Scripture();
    }
}
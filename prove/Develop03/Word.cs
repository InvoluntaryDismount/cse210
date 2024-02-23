// Word class breaks down verse by each word and for each word assigns if it is a boolean. Each word gets its own instance of the Word class
// hiding logic can go in Word class-- if true, print word; if false, count length of word and print that many underscores.

public class Word {
    private string text;
    private bool hidden;

    private int index;

    public Word(string text) {
        this.text = text;
    }

    public Word(string text, int index) {
        this.text = text;
        this.index = index;
    }



    
}
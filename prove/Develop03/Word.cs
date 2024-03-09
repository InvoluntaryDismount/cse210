// Word class breaks down verse by each word and for each word assigns if it is a boolean. Each word gets its own instance of the Word class
// hiding logic can go in Word class-- if true, print word; if false, count length of word and print that many underscores.

public class Word {
    private string text;
    public bool hidden;
    public int index;

    public Word(string text, int wordIndex) {
        this.text = text;
        index = wordIndex;
        }

    public void DisplayWord() {
        if (hidden == false) {
            Console.Write($"{text} ");
        }
        else {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
    }



    
}
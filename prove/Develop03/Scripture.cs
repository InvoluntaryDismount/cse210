public class Scripture {
    public List<Word> WordsList = new List<Word>();
    public List<int> shownIndexes = new List<int>();
    public List<int> hiddenIndexes = new List<int>();

    // constructor that takes argument "text" and separates by spaces, then add word to list of words. This uses the Word class constructor.
    public Scripture (string verseText) {
        string[] words = verseText.Split(" ");
        List<String> verseWords = new List<string>(words);

        var currentIndex = 0;
        foreach (string w in verseWords) {
            
            Word newWord = new Word(w, currentIndex);
            WordsList.Add(newWord);
            shownIndexes.Add(currentIndex);
            currentIndex++;
        }
    }


    // method to hide certain words
    public void HideWords() {
        Random random = new Random();
        int randomNum = random.Next(shownIndexes.Count);
        var randomIndex = shownIndexes[randomNum];
        WordsList[randomIndex].hidden = true;
        hiddenIndexes.Add(randomIndex);
        shownIndexes.Remove(randomIndex);
    }

}
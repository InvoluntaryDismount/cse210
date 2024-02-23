using System;
using System.Transactions;

public class Journal {
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }

    public void DisplayJournal() {
        foreach (Entry entry in entries) {
            entry.DisplayEntries();
        }
    }
}
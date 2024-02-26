using System;
using System.Transactions;
using System.IO;
using System.IO.Enumeration;

public class Journal {
    public List<Entry> entries = new List<Entry>();
    public string fileName;

    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }

    public void DisplayJournal() {
        foreach (Entry entry in entries) {
            entry.DisplayEntries();
        }
    }

    public void WriteJournal(string filename) {
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach (Entry entry in entries) {
                gsdg
            }
        }
    }
}
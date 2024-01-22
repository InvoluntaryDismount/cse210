using System.Threading.Tasks.Dataflow;

public class Job {
    public string company;

    public string jobTitle;

    public int startYear;

    public int endYear;

    public Job(string companyName, string title, int start, int end) {
        company = companyName;
        jobTitle = title;
        startYear = start;
        endYear = end;
    }

    public void Display() {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }

}
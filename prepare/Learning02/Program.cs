using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Del Taco", "Manager", 1706, 2024);
        Job job2 = new Job("Google", "CTO", 2020, 2024);
        

        Resume r = new Resume();
        r._name = "Blake Christensen";

        r._jobs.Add(job1);
        r._jobs.Add(job2);

        r.Display();
    }
}
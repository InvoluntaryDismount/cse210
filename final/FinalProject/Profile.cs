using System.Xml.Serialization;

[Serializable]
public class Profile {
    private string _name;
    private string _gender;
    private int _weightKg;
    private int _heightCm;
    private int _age;
    private double _activityMult;
    private double _bmr;
    private double _TDEE;
    public DailyTotal dt;
    public Protein protein;
    public Fats fats;
    public Carbs carbs;
    public Cal cal;

    public Profile()
    {
        dt = new DailyTotal();
        protein = new Protein();
        fats = new Fats();
        carbs = new Carbs();
        cal = new Cal();
    }

    public void SetDT(DailyTotal dailyTotal)
    {
        dt = dailyTotal;
    }
    
    // public void SetTrackers(Tracker protein, Tracker fats, Tracker carbs, Tracker cal)
    // {
    //     trackers.Add(protein);
    //     trackers.Add(fats);
    //     trackers.Add(carbs);
    //     trackers.Add(cal);
    // }

    public string GetName()
    {
        return _name;
    }

    private void CalcBMR() {
        if (_gender=="M") {
            _bmr = 88.362 + (13.397 * _weightKg) + (4.799 * _heightCm) - (5.677 * _age);
        }
        else {
            _bmr = 447.593 + (9.247 * _weightKg) + (3.098 * _heightCm) - (4.330 * _age);
        }
    }

    public double GetBmr() {
        return _bmr;
    }

    private void CalcTDEE() {
        _TDEE = _bmr * _activityMult;
    }

    public double GetTDEE() {
        return _TDEE;
    }

    public void SetProfile() {
        Console.Clear();
        Console.WriteLine("Profile Setup Initiated");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("Please enter the following information:");
        Thread.Sleep(2000);
        Console.Write("Name: ");
        _name = Console.ReadLine();
        Thread.Sleep(250);
        
        Console.Write("Gender (M/F): ");
        _gender = Console.ReadLine().ToUpper();
        Thread.Sleep(250);

        Console.Write("Weight (kg): ");
        _weightKg = int.Parse(Console.ReadLine());
        Thread.Sleep(250);

        Console.Write("Height (cm): ");
        _heightCm = int.Parse(Console.ReadLine());
        Thread.Sleep(250);

        Console.Write("Age: ");
        _age = int.Parse(Console.ReadLine());
        Thread.Sleep(250);

        Console.WriteLine($"1 - Sedentary (little to no exercise)");
        Console.WriteLine($"2 - Lightly active (light exercise/sports 1-3 days/week)");
        Console.WriteLine($"3 - Moderately active (moderate exercise/sports 3-5 days/week)");
        Console.WriteLine($"4 - Very active (hard exercise/sports 6-7 days a week)");
        Console.WriteLine($"5 - Extra active (very hard exercise/sports & physical job or 2x training)");
        Console.Write("Activity Level (1-5): ");
        var lvl = Console.ReadLine();
        switch (lvl)
        {
            case "1":
                _activityMult = 1.2;
                break;

            case "2":
                _activityMult = 1.375;
                break;

            case "3":
                _activityMult = 1.55;
                break;

            case "4":
                _activityMult = 1.725;
                break;

            case "5":
                _activityMult = 1.9;
                break;
        }
        Thread.Sleep(500);

        // perform calculations
        CalcBMR();
        CalcTDEE();

        Console.Clear();

        // // get filepath to save profile
        // Console.Write("Enter a filepath for the profile: ");
        // _profileFilepath = Console.ReadLine();
        // Thread.Sleep(500);

        Console.WriteLine($"{_name}, your profile has been set up");

    }

    public void Save(Profile profile, XmlSerializer serializer)
    {
        using (TextWriter writer = new StreamWriter($"profiles\\{profile.GetName()}.xml"))
        {
            serializer.Serialize(writer, profile);
        }
    }

    public void Load(Profile profile, XmlSerializer serializer)
    {
        Console.WriteLine("What is the name of the profile you would like to load?");
        var loadName = Console.ReadLine();
        using (TextReader reader = new StreamReader($"profiles\\{loadName}.xml"))
        {
            profile = (Profile)serializer.Deserialize(reader);
        }
    }
}
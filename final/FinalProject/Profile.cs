public class Profile {
    private string _profileFilepath;
    private string _name;
    private string _gender;
    private int _weightKg;
    private int _heightCm;
    private int _age;
    private double _activityMult;
    private double _bmr;
    private double _TDEE;
    private List<DailyTotal> _totals;

    public Profile()
    {

    }

    public string GetFilepath()
    {
        return _profileFilepath;
    }

    public void SetFilepath()
    {
        Console.WriteLine("What would you like to set the filepath to?");
        _profileFilepath = Console.ReadLine();
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
        Thread.Sleep(3000);
        Console.Clear();

        Console.WriteLine("Please enter the following information:");
        Thread.Sleep(3000);
        Console.Write("Name: ");
        _name = Console.ReadLine();
        Thread.Sleep(500);
        
        Console.Write("Gender (M/F): ");
        _gender = Console.ReadLine().ToUpper();
        Thread.Sleep(500);

        Console.Write("Weight (kg): ");
        _weightKg = int.Parse(Console.ReadLine());
        Thread.Sleep(500);

        Console.Write("Height (cm): ");
        _heightCm = int.Parse(Console.ReadLine());
        Thread.Sleep(500);

        Console.Write("Age: ");
        _age = int.Parse(Console.ReadLine());
        Thread.Sleep(500);

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

        // get filepath to save profile
        Console.Write("Enter a filepath for the profile: ");
        _profileFilepath = Console.ReadLine();
        Thread.Sleep(500);

        _totals = new List<DailyTotal>();

        Save();

        Console.WriteLine($"{_name}, your profile has been set up");

    }

    public void Save()
    {
        // save profile
    }

    public void Load(string filepath)
    {
        // load profile
    }
}
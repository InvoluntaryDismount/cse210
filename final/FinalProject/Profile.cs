using System.Xml.Serialization;

[Serializable]
public class Profile {
    public string _name;
    public string _gender;
    public double _weightKg;
    public int _heightCm;
    public int _age;
    public double _activityMult;
    public double _bmr;
    public double _TDEE;

    public string GetName()
    {
        return _name;
    }

    private void CalcBMR() {
        if (_gender=="M") {
            _bmr = (int)Math.Round(88.362 + (13.397 * _weightKg) + (4.799 * _heightCm) - (5.677 * _age));
        }
        else {
            _bmr = (int)Math.Round(447.593 + (9.247 * _weightKg) + (3.098 * _heightCm) - (4.330 * _age));
        }
    }

    public double GetBmr() {
        return _bmr;
    }

    private void CalcTDEE() {
        _TDEE = Math.Round(_bmr * _activityMult);
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
        _weightKg = double.Parse(Console.ReadLine());
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

        // save to profile text file
        SaveProfile();

        Console.WriteLine($"{_name}, your profile has been set up");

    }

    public void SaveProfile()
    {
        string filePath = "saveFolder\\userProfile.csv";
        string profileString = $"{_name},{_gender},{_weightKg},{_heightCm},{_age},{_activityMult},{_bmr},{_TDEE}";
        
        File.WriteAllText(filePath,profileString);
        
        Console.WriteLine("Profile successfully saved");

    }

    public void LoadProfile()
    {
        string filePath = "saveFolder\\userProfile.csv";

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("The CSV file does not exist.");
            return;
        }

        // Read and process the CSV file
        using (StreamReader reader = new StreamReader(filePath))
        {
            // Read current line
            string line = reader.ReadLine();
            
            // Split the line into parts
            string[] parts = line.Split(',');

            _name = parts[0];
            _gender = parts[1];
            _weightKg = Convert.ToDouble(parts[2]);
            _heightCm = Convert.ToInt32(parts[3]);
            _age = Convert.ToInt32(parts[4]);
            _activityMult = Convert.ToDouble(parts[5]);
            _bmr = Convert.ToDouble(parts[6]);
            _TDEE = Convert.ToDouble(parts[7]);
        }
        // check values
        // Console.WriteLine($"Name: {_name}, Gender: {_gender}, Weight: {_weightKg}, Height: {_heightCm}, Age: {_age}, Activity Multiplier: {_activityMult}, BMR: {_bmr}, TDEE: {_TDEE}");
        // Thread.Sleep(5000);
    }

    public void DisplayBmrTDEE() {
        Console.WriteLine($"BMR: {_bmr}, TDEE: {_TDEE}");
    }
}
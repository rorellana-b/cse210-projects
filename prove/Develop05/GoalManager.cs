public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score;

    private int _count = 0;

    private string _folderPath = "savefolder/";

    public GoalManager(){}
    bool exit = false;

    public void Start()
    {
        while (!exit){
            DisplayPlayerPoint();

        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateGoal();
                break;
            case "2":
                Console.WriteLine("");
                ListGoals();
                break;
            case "3":
                SaveGoal();
                break;
            case "4":
                LoadGoals();
                break;
            case "5":
                RecordEvent();
                break;
            case "6":
                Console.WriteLine("Thanks for using this program!");
                return;
            default:
                Console.WriteLine("Invalid choice. Please select a valid goal type.");
                break;
        }
        }
        
    }

    private void DisplayPlayerPoint()
    {
        Console.WriteLine($"\nYou have {_score} points");
    }

    private void ListGoalNames()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetGoalName()}");
            }
            _count = 0;
        }
        else
        {
            Console.WriteLine("The list of goals is empty. Either load your saved goals or create new ones");
        }
    }

    private void ListGoalDetails()
    {
        if (_goals.Count != 0)
        {
            foreach (Goal goal in _goals)
            {
                _count++;
                Console.WriteLine($"{_count}. {goal.GetDetailsString()}");
            }
            _count = 0;
        }
        else
        {
            Console.WriteLine("The list of goals is empty. Either load your saved goals or create new ones");
        }
    }

    private void CreateGoal()
    {
        string[] goalTypes = { "Simple Goal", "Eternal Goals", "Checklist Goals" };

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");

        string goalTypeChoice = Console.ReadLine();
        int goal = int.Parse(goalTypeChoice);
        
        switch (goalTypeChoice)
        {
            case "1":
                SimpleGoal simpleGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(),goal:goalTypes[goal]);
                _goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoal eternalGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(),goal:goalTypes[goal]);
                _goals.Add(eternalGoal);
                break;
            case "3":
                CheckListGoal checkListGoal = new(name: SetGoalName(), description: SetGoalDescription(), points: SetGoalPoint(), bonus: SetBonusPoint(),target: SetCheckListCount());
                _goals.Add(checkListGoal);
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid goal type.");
                break;
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplished: ");
        int goalCompleteIndex = int.Parse(Console.ReadLine());

        Goal goalAccomplished = _goals[goalCompleteIndex - 1];
        goalAccomplished.SetIsCompleteToTrue();
        goalAccomplished.RecordEvent();
        _score += goalAccomplished.GetCurrentPoint();

        string congratMessage = $"\n🎉Congratulations🎉! You have earned {goalAccomplished.GetSetPoint()}\nYou now have {_score} points";
        Console.WriteLine(congratMessage);
        DisplayPlayerPoint();
    }

    private void ListGoals()
    {
        ListGoalDetails();
    }

    private void SaveGoal()
    {
        Console.Write("\nWhat would you like to name the file? : ");
        string fileName = Console.ReadLine();

        using StreamWriter saveGoals = new($"{_folderPath}{fileName}.txt");
        saveGoals.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            saveGoals.WriteLine(goal.GetStringRepresentation());
        }
        _goals.Clear();

    }

    private void LoadGoals()
    {
        string[] files = Directory.GetFiles(_folderPath);

        if (files.Length != 0)
        {
            Console.WriteLine("These are the saved files: ");
            foreach (string file in files)
            {
                _count++;
                Console.WriteLine($"{_count}. {Path.GetFileNameWithoutExtension(file)}");
            }
            _count = 0;

            Console.Write("Choose the file to load (by it number): ");
            int choosenFile = int.Parse(Console.ReadLine());
            string[] fileContent = File.ReadAllLines(files[choosenFile - 1]);

            _goals.AddRange(ConvertToGoalObjects(fileContent));
        }
        else Console.WriteLine("There are no files saved in your Saved-Folder");
    }

    ////////////////////////////////////////////////////////////////////////////////
    ///////// Helper functions
    private string SetGoalName()
    {
        Console.Write("\nWhat is the name of your goal? ");
        string _goalname = Console.ReadLine();
        return _goalname;
    }

    private int SetGoalPoint()
    {
        Console.Write("\nWhat is the amount of points associated with this goal? ");
        int _goalPoint = int.Parse(Console.ReadLine());
        return _goalPoint;
    }

    private string SetGoalDescription()
    {
        Console.Write("\nWhat is a short description of it? ");
        string _goalDescription = Console.ReadLine();
        return _goalDescription;
    }

    private int SetBonusPoint()
    {
        Console.Write("\nWhat is the bonus for accomplish it that many times?  ");
        int _bonusPoint = int.Parse(Console.ReadLine());
        return _bonusPoint;
    }

    private int SetCheckListCount()
    {
        Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
        int _checklistCount = int.Parse(Console.ReadLine());
        return _checklistCount;
    }

    private List<Goal> ConvertToGoalObjects(string[] param)
    {
        _score = int.Parse(param[0]);
        char colon = ':';
        char pipe = ',';
        int start = 1;
        int end = param.Length;
        param = param.Where((value, index) => index >= start && index <= end).ToArray();

        List<Goal> initialGoal = new();

        foreach (string list in param)
        {
            string[] parts = list.Split(colon);
            string goalName = parts[0].Trim();
            string[] contents = parts[1].Split(pipe);

            if (goalName == "Simple Goals")
            {
                SimpleGoal simpleGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()),goal: goalName);
                bool isComplete = bool.Parse(contents[3]);
                if (isComplete) 
                {
                    simpleGoal.SetCheckMark();
                    simpleGoal.SetIsCompleteToTrue();
                }
                initialGoal.Add(simpleGoal);
            }
            if (goalName == "Eternal Goals")
            {
                EternalGoal eternalGoal = new (name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), goal: goalName);
                initialGoal.Add(eternalGoal);
            }
            if (goalName == "Checklist Goals")
            {
                CheckListGoal checkListGoal = new(name: contents[0].Trim(), description: contents[1].Trim(), points: int.Parse(contents[2].Trim()), bonus: int.Parse(contents[3].Trim()), target: int.Parse(contents[4].Trim()));
                bool isComplete = bool.Parse(contents[6]);
                if (isComplete)
                {
                    checkListGoal.SetCheckMark();
                    checkListGoal.SetIsCompleteToTrue();
                } 
                checkListGoal.AddSaveAmountCompleted(int.Parse(contents[5].Trim()));
                initialGoal.Add(checkListGoal);
            }
        }
        Console.WriteLine("\nFile loaded Successfully ✅");
        return initialGoal;
    }

        
}
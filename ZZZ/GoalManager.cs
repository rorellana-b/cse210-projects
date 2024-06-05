public class GoalManager
{
    private List<string> _goals;
    private int _score;

    public GoalManager(){
        _goals = new List<string>();
        _score = 0;
    }

    public List<string> Getgoals(){
        return _goals;
    }

    public int Getscore(){
        return _score;
    }


    
    public void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");

        string goalTypeChoice = Console.ReadLine();

        switch (goalTypeChoice)
        {
            case "1":
                //CreateSimpleGoal(user);
                break;
            case "2":
                //CreateEternalGoal(user);
                break;
            case "3":
                //CreateChecklistGoal(user);
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid goal type.");
                break;
        }
    }






}


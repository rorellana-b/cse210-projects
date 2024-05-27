using System.Reflection.Metadata.Ecma335;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int countduration) : base(name, description, countduration)
    {

    }

    public void Run(int duration)
    {

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(2);
        Console.WriteLine("");

        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You my begin in: ");
        ShowCountDown();

        Console.Clear();
        
        DisplayQuestion();
        Console.WriteLine("");
        DisplayQuestion();
        Console.WriteLine();
        DisplayEndingMassage(duration);
        ShowSpinner(2);
    }

    public void DisplayPrompt()
    {

        Console.WriteLine("Consider the following prompts:");
        Console.WriteLine("");
        Random random = new Random();
        int ramdonIndex = random.Next(GetRamdomPrompt.Length);
        Console.WriteLine($"----{GetRamdomPrompt[ramdonIndex]}----");
        ShowSpinner(2);
        Thread.Sleep(1000);

        Console.WriteLine("");
    }

    public void DisplayQuestion()
    {
        Random random = new Random();
        int ramdonIndex = random.Next(GetRamdomQuestion.Length);
        Console.Write($"> ");
        Console.Write($"{GetRamdomQuestion[ramdonIndex]}");
        ShowSpinner(5);
    }
    public string[] GetRamdomPrompt = new string[]{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."

    };

    public string[] GetRamdomQuestion = new string[]{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


}
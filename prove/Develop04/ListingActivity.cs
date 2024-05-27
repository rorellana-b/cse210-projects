using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class ListingActivity : Activity
{
    private int _count = 0;

    private List<string> _prompts = new List<string>();



    public ListingActivity(string activity, string description, int duration):base(activity, description, duration){

    }
    public void Run(int duration){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(1);
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRamdomPrompt();
    
        _count = GetListFromUser(duration).Count;


        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner(2);
        Console.WriteLine("");               
        DisplayEndingMassage(duration);
        ShowSpinner(2);
    }

    public void GetRamdomPrompt(){
    
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
       
        // Select ramdom prompt for the user
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        Console.WriteLine($"---{_prompts[index]}---");
    }

    public List<string> GetListFromUser(int duration){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        List<string> list = new List<string>();
        Console.WriteLine("You my begin in: ");
        ShowCountDown();
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string entrie = Console.ReadLine();
            list.Add(entrie);
        }
        
        return list;
   }

   
}
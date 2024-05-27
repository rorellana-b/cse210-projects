using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
    

    public BreathingActivity(string activity, string description, int duration):base(activity, description, duration){


    }

    public void Run(int duration){

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(1);
        Console.WriteLine("");
        int seconds = duration;
        // this if funtion make sure that I will start in breathing in
        if(duration % 2 != 1){
            duration += 1;
        }
        // repeat the opcion in the time that the user said
        while (DateTime.Now < endTime)
        {
            if (duration % 2 == 1)
            {
                Console.Write("Breathe in...");
                ShowCountDown();
            }
            else
            {
                Console.Write("Now breathe out...");
                ShowCountDown();
                Console.WriteLine();
            }
            duration -= 1;
            Console.WriteLine();
        }
        DisplayEndingMassage(seconds);
        }



    
        
}
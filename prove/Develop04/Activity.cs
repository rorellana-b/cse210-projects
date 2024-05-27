public class Activity
{
    private string _name = "";
    private string _description = "";
    private int _duration;

    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetDuration(){
        Console.WriteLine("How long, in seconds, would you like for your sesion? ");
        _duration = Convert.ToInt32(Console.Read());
        return _duration;
    }

    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);

    }

    public void DisplayEndingMassage(int seconds){
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        ShowSpinner(1);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {seconds} seconds of the {_name} Activity.");
        ShowSpinner(2);

    }

    public void ShowSpinner(int seconds){

        List<string> spinnerList = new List<string>();
        spinnerList.Add("|");
        spinnerList.Add("/");
        spinnerList.Add("-");
        spinnerList.Add("\\");
        spinnerList.Add("|");
        spinnerList.Add("/");
        spinnerList.Add("-");
        spinnerList.Add("\\");
        
        for (int i = 0; i < seconds; i++)
        {
            foreach (string spinner in spinnerList){
            Console.Write(spinner);
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
        }
        
    }
    public void ShowCountDown() {
        for (int i = 6; i > 0;){
            Console.Write(i);
            i -= 1;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int SetDuration(){
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session?  ");
        int.TryParse(Console.ReadLine(), out int duration);

        return duration;
    }
}
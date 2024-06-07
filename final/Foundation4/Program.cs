using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        List<Activity> exercises= new List<Activity>();

        Running ex1 = new Running("01 Jun 2024", 40, 10);
        exercises.Add(ex1);

        Cycling ex2 = new Cycling("02 Jun 2024",35,50);
        exercises.Add(ex2);

        Swimming ex3 = new Swimming("03 Jun 2022",20,50);
        exercises.Add(ex3);

        Console.Clear();

        Console.WriteLine("--------INFORMATION OF YOUR EXCERCISES.-------");
        Console.WriteLine("");
        foreach (Activity s  in exercises)
        {
            s.GetSummary();
        }
    }
    
}
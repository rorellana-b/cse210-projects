using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";

        Console.WriteLine("Insert yout calification: ");
        string calilf = Console.ReadLine();
        int number = int.Parse(calilf);

        if (number >= 90 )
        {
            letterGrade = "A";
        }
        else if (number >= 80)
        {
            letterGrade = "B";
        }
        else if (number >= 70)
        {
            letterGrade = "C";
        }
        else if (number >= 60)
        {
            letterGrade = "D";
        }
        else if (number < 60)
        {
            letterGrade = "F";
        }
        else
        {
            Console.WriteLine($"Insert a correct value");
        }      
        Console.WriteLine($"Your grade is: {letterGrade}");

        if (number >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Work harder next time!");
        }
    
    }
    
}
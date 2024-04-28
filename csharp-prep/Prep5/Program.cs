using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareNumber(number);

        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string Username = Console.ReadLine();

        return Username;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int UserNumber = int.Parse(Console.ReadLine());

        return UserNumber;
    }

    static int SquareNumber(int number){
        
        int square = number *number;

        return square;
    }
    
}
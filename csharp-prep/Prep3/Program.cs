using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,20);



        //Console.Write("What is the magic number? ");
        //int number = int.Parse(Console.ReadLine());

        int number = -1;
        

        while (number != magicNumber)
        {
            Console.Write("What is your guess? ");
             number = int.Parse(Console.ReadLine());

            if (number > magicNumber){
            Console.WriteLine("Lower");
            }
             else {
            Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You guessed it!!");
    }
    
}
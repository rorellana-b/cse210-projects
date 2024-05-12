using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal myJournal = new Journal();
        
        while (true) {
            
            Console.WriteLine("\nPlease select one of the following choices");
            Console.WriteLine("> 1. Write");
            Console.WriteLine("> 2. Display");
            Console.WriteLine("> 3. Load");
            Console.WriteLine("> 4. Save");
            Console.WriteLine("> 5. Quit");
            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();
        
            //Using methods 
            switch (choice) {
                //Adds new entry
                case "1":
                myJournal.AddEntry();
                break;

                //Displays added entries
                case "2":
                myJournal.DisplayAll();
                break;

                //Loads entries from a file csv
                case "3":
                myJournal.LoadFromFile();
                break;

                //Saves entries to a file
                case "4":
                myJournal.SaveToFile();
                break;

                //Exits program
                case "5":
                Console.WriteLine("Thanks for using this program!");
                return;

                // invalid input
                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
            }
        }
        
    
    }
}
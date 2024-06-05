using System;

class Program
{
    static void Main(string[] args)
    {
        while (true) {
            
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
        
            //Using methods 
            switch (choice) {
                //Adds new entry
                case "1":
                GoalManager manager = new GoalManager();
                manager.CreateNewGoal();
                break;

                //Displays added entries
                case "2":
                Console.WriteLine("2");
                break;

                //Loads entries from a file csv
                case "3":
                Console.WriteLine("3");
                break;

                //Saves entries to a file
                case "4":
                Console.WriteLine("4");
                break;
                
                //Saves entries to a file
                case "5":
                Console.WriteLine("5");
                break;

                //Exits program
                case "6":
                Console.WriteLine("Thanks for using this program!");
                return;

                // invalid input
                default:
                Console.WriteLine("Invalid selection, please enter a number 1-6.");
                break;
            }
        }
        
    
    }
}
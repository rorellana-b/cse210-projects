using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        int duration = 0;
        
        while (!exit)
        {

            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This Activity will help you relax by walking your breathing in and out slowly. Clear your mind and focus on your breathing.", duration);

                breathingActivity.DisplayStartingMessage();
                Console.WriteLine("");

                duration = breathingActivity.SetDuration();

                if (duration > 0)
                    breathingActivity.Run(duration);
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",duration);
                
                reflectingActivity.DisplayStartingMessage();
                Console.WriteLine("");
                duration = reflectingActivity.SetDuration();

                if (duration > 0)
                    reflectingActivity.Run(duration);
            }
            else if (choice == "3")
            {


                ListingActivity listingActivity = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",duration);

                listingActivity.DisplayStartingMessage();
                Console.WriteLine(""); 

                duration = listingActivity.SetDuration();

                if (duration > 0)
                    listingActivity.Run(duration);
                
            }

            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select an activity (1-4).");
                Thread.Sleep(2000);
            }


        }
    }
}



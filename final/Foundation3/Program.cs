using System;

class Program
{
    static void Main(string[] args)
    {

            string[] listOfEvents = {"Lectures", "Receptions", "Outdoors"};
       

        Console.WriteLine("");
        Console.WriteLine($"Which event would you like to plan: 1.{listOfEvents[0]}  |  2.{listOfEvents[1]}  |  3.{listOfEvents[2]}");
        string theEvent = Console.ReadLine().ToLower();
        Console.WriteLine("");

        void StandardMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Standard Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }
        void FulldMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Full Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }
        void ShortMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Short Format - Event Information: ");
            Console.WriteLine("_______________________________________");
        }

        switch (theEvent)
        {
            case "1":
                Lectures lectures = new();
                lectures.BookLectureEvent();

                StandardMessage();
                lectures.DisplayStandarDetail();

                FulldMessage();
                lectures.DisplayFullDetails();

                ShortMessage();
                lectures.DisplayShortDetails();
                break;

            case "2":
                Receptions reception = new();
                reception.BookReceptionEvent();

                StandardMessage();
                reception.DisplayStandarDetail();

                FulldMessage();
                reception.DisplayFullDetails();

                ShortMessage();
                reception.DisplayShortDetails();
                break;

            case "3":
                Outdoor outdoor = new();
                outdoor.BookEvent();

                StandardMessage();
                outdoor.DisplayStandarDetail();

                FulldMessage();
                outdoor.DisplayFullDetails();

                ShortMessage();
                outdoor.DisplayShortDetails();
                break;

            default:
                Console.WriteLine("[❗️❗️❗️...Invalid Event] - You entered an event that's not in the list of events we plan");
                break;
        }
           
    }
    
}
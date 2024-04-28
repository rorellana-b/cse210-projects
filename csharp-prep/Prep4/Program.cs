using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers;
        numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // variable declaration
        int number;
        int sum = 0;
        int max = 0;

        //process to ask numbers to users
        do 
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0){
                numbers.Add(number);
            }
            
        } while(number != 0);

       
        // iterate a list and made an adition 
        foreach (int data in numbers)
        {
            sum += data;
             
            //calculate the large value
            if (data > max ){
                max = data;
            }
        }

        //Print the first result
        Console.WriteLine($"The sum is: {sum}");

        // calculate the average
       float average = ((float)sum) / numbers.Count;
       Console.WriteLine($"The average is: {average}");

       //Print the max value
        Console.WriteLine($"The largest number is: {max}");
    }
}
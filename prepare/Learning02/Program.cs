using System;

class Program
{
    static void Main(string[] args)
    
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engenire";
        job1._company = "Apple";
        job1._startYear = "2020";
        job1._endYear = "2024";

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Microsoft";
        job2._startYear = "2019";
        job2._endYear = "2020";

        //Console.WriteLine(job1._jobTitle);
        //Console.WriteLine(job1._company);
        //job1.Display();

        Resume myResume = new Resume();
        myResume._name = "Ronal Orellana";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}
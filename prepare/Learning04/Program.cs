using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Assigment a1 = new Assigment("Ronal Orellana","Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssigment a2 = new MathAssigment("Roberto Rodriguez","Fractions","7.3","8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssigment a3 = new WritingAssigment("Mary Waters", "European History", "The Causes of Workd War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}
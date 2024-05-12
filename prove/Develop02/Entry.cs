using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        // structure display on the screem 
        Console.WriteLine($"\nDate: {_date}-Promt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}
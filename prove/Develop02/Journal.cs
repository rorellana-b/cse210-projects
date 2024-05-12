using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries;

    public PromptGenerator promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void AddEntry()
    {

        Entry entry = new Entry();
        // add current time
        DateTime currentTime = DateTime.Now;
        entry._date = currentTime.ToShortDateString();

        //Getting a ramdom promt
        string text = promptGenerator.GetRandomPrompt();
        entry._promptText = text;

        Console.WriteLine($"{text}");
        Console.Write(">");
        entry._entryText = Console.ReadLine();
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }
    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal entries saved to {filename}");
    }

    public void LoadFromFile()
    {
    
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);

        }



    }
}
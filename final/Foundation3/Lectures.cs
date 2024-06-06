public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(){
        SetEventType("lectures");
    }

    public void SetSpeaker(){
        Console.Write("What is the speaker name? ");
        _speaker = Console.ReadLine();
    }
    public string GetSpeaker(){
        return _speaker;
    }
    public void SetCapacity(){
        Console.Write("Insert the capacity of attendees: ");
        
        
    }
    public int GetCapacity(){
        return _capacity;
    }

    public void BookLectureEvent(){
        SetSpeaker();
        SetCapacity();
        BookEvent();
    }

    public void DisplayFullDetails(){
        Console.WriteLine($"\nSpeaker: {GetSpeaker()}\nEvent capacity: {GetCapacity()}\n");
        DisplayStandarDetail();
    }
}
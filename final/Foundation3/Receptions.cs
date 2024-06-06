public class Receptions : Event
{
    private string _RSVP;
    private int _attendece;

    public Receptions(){
        SetEventType("Reception");
    }

    public void SetRSVP(){
        Console.Write("What is your Name? ");
        _RSVP = Console.ReadLine();
    }

    public string GetRSVP(){
        return _RSVP;
    }

    public void SetAttendence(){
        Console.Write("How many will attendece? ");
        _attendece = int.Parse(Console.ReadLine());
    }

    public int GetAttendece(){
        return _attendece;
    }

    public void BookReceptionEvent(){
        SetRSVP();
        SetAttendence();
        BookEvent();
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine($"RSVP: {GetRSVP()}\nNumber of attendee: {GetAttendece()}");
        DisplayStandarDetail();
    }
    
}
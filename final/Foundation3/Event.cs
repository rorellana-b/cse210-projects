public class Event
{   
    private string _eventType;
    private string _tittle;
    private string _description;
    private string _date;
    private string _time;

    public Event(){

    }

    public void SetEventType( string eventType){
        _eventType = eventType;
    } 
    public string GetEventType(){
        return _eventType;
    }

    public void SetTittle(){
        Console.Write("Inser the event Tittle: ");
        _tittle = Console.ReadLine();
    }

    public string Gettitle(){
        return _tittle;
    }

    public void SetDescription(){
        Console.Write("Insert the event description: ");
        _description = Console.ReadLine();
    }
    public string GetDescription() {
        return _description;
    }

    public void SetDate()
    {
        Console.Write("Insert the date of the event (MM-DD-YY): ");
        _date = Console.ReadLine();
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetTime()
    {
        Console.Write("Insert the event time: ");
        _time = Console.ReadLine();
    }

    public string GetTime()
    {
        return _time;
    }

    public void BookEvent(){
        SetTittle();
        SetDescription();
        SetDate();
        SetTime();

    }

    public void DisplayStandarDetail(){
        Console.WriteLine($"Event name: {Gettitle()}\nEvent Description: {GetDescription()}\nEvent Date: {GetDate()}Time: {GetTime()}");

        //\n{_address.DisplayAddressInfo()
    }
    public void DisplayShortDetails()
    {
        Console.WriteLine($"Event type: {GetEventType()}\nEvent title: {Gettitle()}\nEvent date: {GetDate()}");
    }
}
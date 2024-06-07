public abstract class Activity
{

    protected string _date;
    protected double _exerciseDuration;
    private string _exerciseTitle;
    private double _distance;
    private double _speed;
    private double _pace;

    public Activity(string date, double exerciseDuration)  {
        _date = date;
        _exerciseDuration = exerciseDuration;
     }

    private void SetExerciseTitle( string exerciseTitle )
    {
        _exerciseTitle = exerciseTitle;
    }
    private string GetExerciseTitle()
    {
        return _exerciseTitle;
    }

    private void SetExerciseDuration(double exerciseDuration )
    {
        _exerciseDuration = exerciseDuration;
    }
    protected double GetExerciseDuration()
    {
        return _exerciseDuration;
    }

    
    public void  SetCalculatedSpeed()
    {
        _speed = Math.Round(CalculateSpeed(), 1);
    }

    private double GetCalculatedSpeed()
    {
        SetCalculatedSpeed();
        return _speed;
    }

    public void SetCalculatedPace()
    {
        _pace = Math.Round(CalculatePace(), 1);
    }

    private double GetCalculatedPace()
    {
        SetCalculatedPace();
        return _pace;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    

    public virtual void GetSummary()
    {
        string summary = $"{_date} {GetExerciseTitle()} ({GetExerciseDuration()} min):  Distance {CalculateDistance()} km/h, Speed {GetCalculatedSpeed()} km/h, Pace {GetCalculatedPace()} min per Km";
        Console.WriteLine(summary);

    }
}
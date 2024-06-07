public class Swimming : Activity
{
     private int _numberOfLaps;

    public Swimming(string date, double exerciseDuration, int numberOfLaps ) : base(date, exerciseDuration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public void SetSwimmingLaps(int numberOfLaps)
    {
        _numberOfLaps = numberOfLaps;
    }

    public int GetSwimmingLaps()
    {
        return _numberOfLaps;
    }

    public override double CalculateDistance()
    {
        double computeDistance = _numberOfLaps * 50 / 1000;
        return Math.Round(computeDistance,2);
    }

    public override double CalculateSpeed()
    {
        double computeSpeed = ((_numberOfLaps * 50 / 1000)/_exerciseDuration) * 60;
        return Math.Round(computeSpeed,2);
    }

    public override double CalculatePace()
    {
        double computePace = _exerciseDuration / (_numberOfLaps * 50 / 1000);
        return computePace;
    }
}
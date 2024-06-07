public class Running : Activity
{
    private double _runningDistance;

    public Running(string date, double exerciseDuration, double runningDistance) : base(date, exerciseDuration)
    { 
        _runningDistance = runningDistance;
    }

    public void SetRunningDistance(double runningDistance)
    {
        _runningDistance = runningDistance;
    }

    public double GetRunningDistance()
    {
        return _runningDistance;
    }

    public override double CalculateDistance()
    {
        return Math.Round(_runningDistance,2);
    }

    public override double CalculateSpeed()
    {
        double computeSpeed = (_runningDistance/_exerciseDuration) * 60;
        return Math.Round(computeSpeed,2);
    }

    public override double CalculatePace()
    {
        double computePace = _exerciseDuration / _runningDistance;
        return computePace;
    }

}
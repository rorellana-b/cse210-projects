public class Cycling : Activity
{
    private double _cyclingSpeed;
    

    public Cycling(string date, double exerciseDuration, double cyclingSpeed ) : base(date, exerciseDuration)
    {
        _cyclingSpeed = cyclingSpeed;
    }

    public void SetCyclingSpeed( double cyclingSpeed )
    {
        _cyclingSpeed =  cyclingSpeed;
    }

    private double GetCyclingSpeed()
    {
        return _cyclingSpeed;
    }

    public override double CalculateDistance()
    {
        double computeDistance =   _cyclingSpeed * (_exerciseDuration / 60);
        return Math.Round(computeDistance,2);
    }

    public override double CalculateSpeed()
    {
        return _cyclingSpeed;
    }

    public override double CalculatePace()
    {
        double computePace = _exerciseDuration / (_cyclingSpeed * (_exerciseDuration / 60));
        return Math.Round(computePace,2);
    }

}
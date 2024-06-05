using System.Reflection.Metadata;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal (string name, string description, string points){
        _shortName = name;
        _description = description;
        _points = points;
    }



    public abstract void RecordEvent();

    public abstract bool isComplete();

    public abstract string GetDetailsString() ;

    public abstract string GetStringRepresantation();


    // GETTERS AND SETTERS


    public string GetShortName() {
        return _shortName;
    }

    public string GetDescription() {
        return _description;
    }

    

}
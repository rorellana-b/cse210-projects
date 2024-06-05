public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description,string points): base (name, description, points){

        _isComplete = true;

    }

    public override string GetDetailsString(){
        return "";
    }
    public override string GetStringRepresantation(){
        return "";
    }

    public override bool IsComplete(){
        return _isComplete;
    }
}
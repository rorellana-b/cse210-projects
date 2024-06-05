public class CheckListGoal : Goal
{
    private string _typeOfGoal;
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    private bool _isComplete = false;

    public CheckListGoal(string name, string description, int points, int bonus,int target) : base(name, description, points)
    {
        _typeOfGoal = "Checklist Goals";
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (IsComplete() && GetAmountCompleted() == _target)
        {
            AddSetPointToCurrentPoint();
            SetCheckMark();
        }
        else
        {
            AddSetPointToCurrentPoint();
            SetAmountCompleted();
            _isComplete = false;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{GetCheckMark()} {_shortName} - {_description} -- Currently completed {GetAmountCompleted()}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_shortName} , {_description} , {_setPoints} , {_bonus} , {_target} , {GetAmountCompleted()} , {IsComplete()}";
    }

    public void SetAmountCompleted()
    {
        _amountCompleted++;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }

    public void AddSaveAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

}
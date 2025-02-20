public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int userScore)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            userScore += _points;
        }
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X] " + _name : "[ ] " + _name;
    }

    public override string SaveFormat()
    {
        return $"SimpleGoal,{_name},{_points},{_isComplete}";
    }
}
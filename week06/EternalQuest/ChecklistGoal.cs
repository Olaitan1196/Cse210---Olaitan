public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        _target = target;
        _count = 0;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int userScore)
    {
        _count++;
        userScore += _points;
        if (_count == _target)
        {
            _isComplete = true;
            userScore += _bonus;
        }
    }

    public override string GetStatus()
    {
        return _isComplete ? $"[X] {_name} (Completed {_count}/{_target})" : $"[ ] {_name} (Completed {_count}/{_target})";
    }

    public override string SaveFormat()
    {
        return $"ChecklistGoal,{_name},{_points},{_count},{_target},{_bonus}";
    }
}
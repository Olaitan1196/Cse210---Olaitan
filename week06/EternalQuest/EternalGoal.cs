public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int userScore)
    {
        userScore += _points; // Always earn points
    }

    public override string GetStatus()
    {
        return "[∞] " + _name;
    }

    public override string SaveFormat()
    {
        return $"EternalGoal,{_name},{_points}";
    }
}
using System;

public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent(ref int userScore);
    
    public abstract string GetStatus();
    
    public abstract string SaveFormat();
}

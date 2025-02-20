using System;

abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance(); // Must be overridden
    public abstract double GetSpeed();    // Must be overridden
    public abstract double GetPace();     // Must be overridden

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
    }
}

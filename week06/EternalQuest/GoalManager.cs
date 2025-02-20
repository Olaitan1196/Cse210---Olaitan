using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _userScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _userScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent(ref _userScore);
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
        Console.WriteLine($"Total Score: {_userScore}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_userScore);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.SaveFormat());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                _userScore = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(",");
                    string type = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[3]);
                            SimpleGoal simpleGoal = new SimpleGoal(name, points);
                            if (isComplete) simpleGoal.RecordEvent(ref _userScore);
                            _goals.Add(simpleGoal);
                            break;

                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, points));
                            break;

                        case "ChecklistGoal":
                            int count = int.Parse(parts[3]);
                            int target = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, points, target, bonus);
                            for (int i = 0; i < count; i++) checklistGoal.RecordEvent(ref _userScore);
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
        }
    }
}

using System;

// Features Beyond Requirements
// Gamification: Checklist goals include bonuses.
// Persistence: Goals & scores are saved/loaded from a file.
//  User-Friendly Menu: Interactive menu to manage goals.

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        string filename = "goals.txt";

        manager.LoadGoals(filename);

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Simple Goal");
            Console.WriteLine("2. Add Eternal Goal");
            Console.WriteLine("3. Add Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Save & Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Goal Name: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Points: ");
                    int points1 = int.Parse(Console.ReadLine());
                    manager.AddGoal(new SimpleGoal(name1, points1));
                    break;

                case 2:
                    Console.Write("Goal Name: ");
                    string name2 = Console.ReadLine();
                    Console.Write("Points per completion: ");
                    int points2 = int.Parse(Console.ReadLine());
                    manager.AddGoal(new EternalGoal(name2, points2));
                    break;

                case 3:
                    Console.Write("Goal Name: ");
                    string name3 = Console.ReadLine();
                    Console.Write("Points per completion: ");
                    int points3 = int.Parse(Console.ReadLine());
                    Console.Write("Times needed to complete: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name3, points3, target, bonus));
                    break;

                case 4:
                    manager.DisplayGoals();
                    Console.Write("Enter goal number to record: ");
                    int goalNum = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(goalNum);
                    break;

                case 5:
                    manager.DisplayGoals();
                    break;

                case 6:
                    manager.SaveGoals(filename);
                    return;
            }
        }
    }
}
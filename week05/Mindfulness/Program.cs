// Program.cs
//Features That Exceed Requirements
//Ensures unique prompts/questions before repeats (Reflection & Listing Activities).
//User can enter unlimited responses in Listing Activity until time runs out.
//Better breathing animation with a countdown.
//Simple yet clean UI with structured prompts and timers.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("\nSelect an option: ");
            
            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => throw new InvalidOperationException("Invalid choice! Please enter a number from 1 to 4.")
            };

            if (activity == null) break;

            activity.Run();
            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}

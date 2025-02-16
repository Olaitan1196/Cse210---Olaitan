
using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Exercise", "This activity helps you relax by guiding deep breathing. Clear your mind and focus on your breath.")
    {
    }

    public override void Run()
    {
        StartActivity();
        
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }

        EndActivity();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}

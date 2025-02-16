
using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private static readonly List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?",
        "How can you apply this experience in the future?"
    };

    public ReflectionActivity() 
        : base("Reflection Exercise", "This activity helps you reflect on moments of strength and resilience in your life.")
    {
    }

    public override void Run()
    {
        StartActivity();

        Random rand = new();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine($"\n{_questions[rand.Next(_questions.Count)]}");
            ShowSpinner(5);
            elapsed += 5;
        }

        EndActivity();
    }
}

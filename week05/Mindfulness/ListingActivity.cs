
using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private static readonly List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Exercise", "This activity helps you reflect on the good things in your life by listing them.")
    {
    }

    public override void Run()
    {
        StartActivity();

        Random rand = new();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        ShowSpinner(3);
        Console.WriteLine("Start listing your answers (press Enter after each item).");

        List<string> responses = new();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        EndActivity();
    }
}

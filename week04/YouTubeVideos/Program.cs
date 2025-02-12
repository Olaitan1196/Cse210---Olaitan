using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create Video objects
        Video video1 = new Video("How to Code in C#", "John Doe", 600);
        Video video2 = new Video("Introduction to AI", "Jane Smith", 450);
        Video video3 = new Video("The History of Space Travel", "Elon Fan", 720);

        // Add comments to each video
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Loved the explanation."));

        video2.AddComment(new Comment("Dave", "AI is the future!"));
        video2.AddComment(new Comment("Emma", "Thanks for simplifying it."));
        video2.AddComment(new Comment("Frank", "This was super helpful."));

        video3.AddComment(new Comment("Grace", "I want to go to Mars!"));
        video3.AddComment(new Comment("Hank", "Space exploration is amazing."));
        video3.AddComment(new Comment("Ivy", "Well explained."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list and display video info
        Console.WriteLine("\nVideo Library:");
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

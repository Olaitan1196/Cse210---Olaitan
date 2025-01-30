using System;

class Program
{
    static void Main()
    {
        //What I added to exceed the requirements of the assignment:
        // Supports multiple verses (e.g., "Proverbs 3:5-6")
        // Ensures hidden words are not selected again
        // Encapsulation with multiple classes and access modifiers
        // Can be easily extended (e.g., loading scriptures from a file)
        
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Goodbye!");
    }
}

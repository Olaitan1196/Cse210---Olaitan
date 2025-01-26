using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
        Console.WriteLine("Entry added successfully!");
    }

    public void Display()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            Console.WriteLine("\nJournal Entries:");
            foreach (Entry entry in entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string filename)
    {
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt"; // Ensure file has .txt extension
        }

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved successfully to {filename}!");
    }

    public void LoadFromFile(string filename)
    {
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt"; // Ensure file has .txt extension
        }

        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[1], parts[2], parts[0]));
                }
            }
            Console.WriteLine($"Journal loaded successfully from {filename}!");
        }
        else
        {
            Console.WriteLine($"Error: File '{filename}' not found.");
        }
    }
}

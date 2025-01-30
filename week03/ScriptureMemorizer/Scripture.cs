using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
        random = new Random();
    }

    public string GetDisplayText()
    {
        return $"{reference.GetDisplayText()} - " + string.Join(" ", words.Select(word => word.GetDisplayText()));
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden());
    }
}

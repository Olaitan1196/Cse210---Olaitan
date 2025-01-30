using System;

class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse == -1 ? startVerse : endVerse;
    }

    public string GetDisplayText()
    {
        return endVerse == startVerse ? $"{book} {chapter}:{startVerse}" : $"{book} {chapter}:{startVerse}-{endVerse}";
    }
}

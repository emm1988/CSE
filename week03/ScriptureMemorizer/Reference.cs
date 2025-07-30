class Reference
{
    private string _book; 
    private int _chapter;
    private int _verse;
    private int _lastVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _lastVerse = endVerse;
    }


    public string GetDisplayText()
    {
        if (_verse == _lastVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        return $"{_book} {_chapter}:{_verse}-{_lastVerse}";
    }
}
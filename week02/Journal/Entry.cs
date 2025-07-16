using System;

public class Entry
{
    public string _date {get;}
    public string _prompt {get; }
    public string _entry {get; }

    public Entry(string prompt, string entry)
    {
        _date = DateTime.Now.ToString("yyyy/MM/dd");
        _prompt = prompt;
        _entry = entry;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine();
    }
}


























/*
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string _date;

    public string _prompt;
    
    public string _entry;

    public Entry()
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public void Display()
    {

    }
}
*/
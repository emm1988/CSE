using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        string filename = Console.ReadLine();
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._prompt}|{entry._entry}");
            }
        }
    }
    
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    Entry entry = new Entry(parts[0], parts[1]);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("File loaded successfully.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
    
}


























/*
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry entry)
    {
        if (_entries == null)
        {
            _entries = new List<Entry>();
        }
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries == null || _entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            if (_entries != null)
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
                }
            }
        }
        Console.WriteLine($"Entries saved to {file}");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"File {file} does not exist.");
            return;
        }

        _entries = new List<Entry>();
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _entry = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine($"Entries loaded from {file}");
    }
}
*/
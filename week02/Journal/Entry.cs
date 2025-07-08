using System;
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
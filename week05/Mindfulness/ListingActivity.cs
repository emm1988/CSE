using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt spiritual inspiration this month?",
            "Who are some of your personal heroes?"
        };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by listing as many things as you can in a specific area.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt:\n--- {prompt} ---\n");
        Console.WriteLine("You will have a few seconds to think about your answers.");
        ShowCountDown(7);

        Console.WriteLine("\nStart listing items (press Enter after each):");

        List<string> items = new List<string>();
        Stopwatch sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < GetDuration())
        {
            Console.Write("> ");
            string entry = ReadLineWithinTime(GetDuration() - (int)sw.Elapsed.TotalSeconds);
            if (entry == null) break;
            if (!string.IsNullOrWhiteSpace(entry))
            {
                items.Add(entry.Trim());
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items:");
        foreach (var it in items)
        {
            Console.WriteLine($" - {it}");
        }

        DisplayEndingMessage();
    }

    private string ReadLineWithinTime(int timeoutSeconds)
    {
        if (timeoutSeconds <= 0) return null;

        string result = "";
        Stopwatch sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < timeoutSeconds)
        {
            while (Console.KeyAvailable)
            {
                var k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return result;
                }
                else if (k.Key == ConsoleKey.Backspace)
                {
                    if (result.Length > 0)
                    {
                        result = result.Substring(0, result.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    result += k.KeyChar;
                    Console.Write(k.KeyChar);
                }
            }
            Thread.Sleep(100);
        }
        Console.WriteLine();
        return null;
    }
}

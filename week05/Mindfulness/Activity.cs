using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;


class Activity
    {
        private string _name;
        private string _description;
        private int _duration; 
        protected static readonly Random _rand = new Random();

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"=== {_name} ===\n");
            Console.WriteLine(_description + "\n");

            while (true)
            {
                Console.Write("Enter duration in seconds: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int seconds) && seconds > 0)
                {
                    _duration = seconds;
                    break;
                }
                Console.WriteLine("Please enter a valid positive number.");
            }

            Console.WriteLine("\nGet ready...");
            Spinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\n\nWell done!");
            Spinner(2);
            Console.WriteLine($"\nYou have completed the activity for {_duration} seconds.");
            Spinner(4);
        }

        protected void Spinner(int seconds)
        {
            char[] spinner = { '|', '/', '-', '\\' };
            Stopwatch sw = Stopwatch.StartNew();
            int idx = 0;
            while (sw.Elapsed.TotalSeconds < seconds)
            {
                Console.Write(spinner[idx++ % spinner.Length]);
                Thread.Sleep(500);
                Console.Write("\b");
            }
            Console.Write(" ");
            Console.WriteLine();
        }

        protected void ShowCountDown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\r  \r");
            }
        }

        public int GetDuration() => _duration;
    }
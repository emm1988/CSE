using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different from other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience for other situations?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectingActivity() : base(
            "Reflection Activity",
            "This activity will help you reflect on times when you showed strength and resilience.")
        { }

        public void Run()
        {
            DisplayStartingMessage();
            string prompt = _prompts[_rand.Next(_prompts.Count)];
            Console.WriteLine("\nConsider the following prompt:\n");
            Console.WriteLine($"--- {prompt} ---\n");
            Console.WriteLine("When you have something in mind, press Enter to continue...");
            Console.ReadLine();

            Spinner(3);

            Stopwatch sw = Stopwatch.StartNew();
            while (sw.Elapsed.TotalSeconds < GetDuration())
            {
                string q = _questions[_rand.Next(_questions.Count)];
                Console.WriteLine($"\n> {q}");
                int pauseSeconds = 5;
                if (sw.Elapsed.TotalSeconds + pauseSeconds > GetDuration())
                {
                    pauseSeconds = GetDuration() - (int)sw.Elapsed.TotalSeconds;
                }
                Spinner(pauseSeconds);
            }

            DisplayEndingMessage();
        }
    }



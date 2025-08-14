using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

class BreathingActivity : Activity
    {
        public BreathingActivity() : base(
            "Breathing Activity",
            "This activity will help you relax by guiding you to breathe in and out slowly. Clear your mind and focus on your breathing.")
        { }

        public void Run()
        {
            DisplayStartingMessage();
            int elapsed = 0;
            while (elapsed < GetDuration())
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountDown(3);
                elapsed += 3;
                if (elapsed >= GetDuration()) break;

                Console.WriteLine("Breathe out...");
                ShowCountDown(3);
                elapsed += 3;
            }
            DisplayEndingMessage();
        }
    }

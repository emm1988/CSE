using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
    {
        static void Main(string[] args)
        {
            var breathing = new BreathingActivity();
            var listing = new ListingActivity();
            var reflecting = new ReflectingActivity();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("----- MINDFULNESS APP -----");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Listing Activity");
                Console.WriteLine("3. Reflecting Activity");
                Console.WriteLine("4. Quit");
                Console.Write("\nChoose an activity: ");
                string choice = Console.ReadLine()?.Trim();

                if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else if (choice == "1")
                {
                    breathing.Run();
                }
                else if (choice == "2")
                {
                    listing.Run();
                }
                else if (choice == "3")
                {
                    reflecting.Run();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Press Enter to try again...");
                    Console.ReadLine();
                }
            }
        }
    }
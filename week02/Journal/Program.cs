using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();

        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    anEntry._entry = Console.ReadLine();
                    anEntry._date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    theJournal.AddEntry(anEntry);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    theJournal.SaveToFile("journal.txt");
                    break;
                case "4":
                    theJournal.LoadFromFile("journal.txt");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        anEntry._entry = Console.ReadLine();
        anEntry._date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        theJournal.AddEntry(anEntry);
        theJournal.DisplayAll();
        theJournal.SaveToFile("journal.txt");
        theJournal.LoadFromFile("journal.txt");
        Console.WriteLine("Journal entries saved and loaded successfully.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        
    }
}
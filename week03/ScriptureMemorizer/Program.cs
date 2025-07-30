using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! This is the ScriptureMemorizer Program.");

        Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.Hidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("I hope you enjoyed the Scripture Memorizer. Thank you!");
                return;
            }

            scripture.HideRandomWords(3);
        }
    }
}
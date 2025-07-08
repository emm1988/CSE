using System;
//fifth exercise in C#
class Program
{
    static void Main(string[] args)
    {   
        DisplayWelcome();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int squarednumber = SquareNumber(usernumber);
        DisplayResult(username, squarednumber);
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string username = Console.ReadLine();
            return username;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string usernumberInput = Console.ReadLine();
            int usernumber = int.Parse(usernumberInput);
            return usernumber;
        }

        static int SquareNumber(int usernumber)
        {
            int squared = usernumber * usernumber;
            return squared;
        }

        static void DisplayResult(string username, int squarednumber)
        {
            Console.WriteLine($"Hello {username}, the square of your number is {squarednumber}.");
        }
        
    }
}
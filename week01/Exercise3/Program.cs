using System;
//third exercise in C#
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your magic number?");
        string magicNumber = Console.ReadLine();
        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        int magicNumberValue = int.Parse(magicNumber);

        while (guess != magicNumber)
        {
            Console.WriteLine("Nope, try again.");
            Console.WriteLine("What is your guess?");
            guess = Console.ReadLine();

            int guessNumber = int.Parse(guess);

            if (magicNumberValue > guessNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (magicNumberValue < guessNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            
            else
            {
                Console.WriteLine("You got it!");
            }
        }


    }
}
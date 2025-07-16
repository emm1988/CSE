using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! My name is Emmanuel.");
        // this is a comment
        string name = "Emmanuel";
        Console.WriteLine($"Hello, {name}!");

        int number = 42;
        Console.WriteLine($"The number is: {number}");

        double pi = 3.14159;
        Console.WriteLine($"The value of pi is approximately: {pi}");

        bool myboolean = true;
        Console.WriteLine($"The boolean value is: {myboolean}");

        var myVar = new string[] { "apple", "banana", "cherry" };
        Console.WriteLine("My array contains:");
        foreach (var item in myVar)
        {
            Console.WriteLine($" - {item}");
        }

    }
}

    
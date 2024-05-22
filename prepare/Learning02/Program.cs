using System;

class Program
{
    static void Main()
    {
        // Display text and prompt the user for input on the same line
        Console.Write("Enter your name: ");

        // Read the input provided by the user
        string name = Console.ReadLine();

        // Display a greeting message with the user's name
        Console.WriteLine("Hello, " + name + "! It's nice to meet you.");
    }
}

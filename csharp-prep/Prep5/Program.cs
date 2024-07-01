using System;

class Program
{
    static void Main(string[] args)
    {
        welcomemessage();

        string username = askusername();
        int usernumber = askusernumber();

        int squarednumber = squarenumber(usernumber);

        DisplayResult(username, squarednumber);
    }

    static void welcomemessage()
    {
        Console.WriteLine("Hi! welcome to this prep 5 program.");
    }

    static string askusername()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int askusernumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squarenumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

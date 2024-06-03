using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number");
        int magic_number = Convert.ToInt32(Console.ReadLine());
        int guess;
        while (guess != magic_number)
        {
            Console.WriteLine("Guess what the magic number is:");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > magic_number)
            {
                Console.WritLine("Lower");
            }else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }else if (guess == magic_number)
            {
                break;
            }else {Console.WriteLine("Invalid Input");}
        }
    }
}

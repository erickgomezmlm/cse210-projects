using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_num = 1;
        while(user_num != 0)
        {
            Console.WriteLine("Enter a number (press 0 to quit)");
            string user_input = Console.ReadLine();
            user_num = int.Parse(user_input);

            if (user_num != 0)
            {
                numbers.Add(user_num);
            }
            
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("The sum of all numbers is: " + sum);

        float average = sum / numbers.Count;

        Console.WriteLine("The average is: " + average);

        int max = numbers.Max();

        Console.WriteLine("Your max number is: " + max);
    }
}        

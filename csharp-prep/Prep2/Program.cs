using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter you're grade percent:");
        int grade = Convert.ToInt32(Console.ReadLine());
        string grade_claim;
        if (grade >= 90)
        {
            grade_claim = "A";
        }else if (grade >= 80)
        {
            grade_claim = "B";
        }else if (grade >= 70)
        {
            grade_claim = "C";
        }else if (grade >= 60)
        {
            grade_claim = "D";
        }else {grade_claim = "F";}

        Console.WriteLine("You got a "+grade_claim);
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assinment01 = new Assignment("Samuel Bennet", "multiplication");
        assinment01.GetSummery();
        MathAssignment assignment02 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        assignment02.GetSummery();
        assignment02.GetHomeworkList();

        WritingAssignment assignment03 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        assignment03.GetSummery();
        assignment03.GetWritingInformation();


        
    }
}

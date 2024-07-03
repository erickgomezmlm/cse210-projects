using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sofware Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Chicfila";
        job2._startYear = 2010;
        job2._endYear = 2015;


        Resume my_resume = new Resume();
        my_resume._name = "Erick";

        my_resume._jobs.Add(job1);
        my_resume._jobs.Add(job2);

        my_resume.Display();
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        List<GoalBase> goals = new List<GoalBase>();
        bool gameactive = true;
        while (gameactive)
        {
            Console.WriteLine($"You have {GoalBase.GetColectiveScore()} points\n");
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create new goal\n2. List goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.WriteLine("Select a choice from the menu");
            int baseuserinput = Convert.ToInt32(Console.ReadLine());
            if (baseuserinput == 1)
            {
                AddGoals();
            }
            else if (baseuserinput == 2)
            {
                Listgoals();
            }
            else if (baseuserinput == 3)
            {
                Console.WriteLine("What is the filename for the goal file?");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"{GoalBase.GetColectiveScore()}");
                    foreach (GoalBase goal in goals)
                    {
                        outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                    }
                }
            }
            else if (baseuserinput == 4)
            {
                LoadGoals();
            }
            else if (baseuserinput == 5)
            {
                RecordGoals();
            }
            else if (baseuserinput == 6)
            {
                gameactive = false;
            }
        }
        void AddGoals()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
            Console.WriteLine("What type of Goal would you like to create? ");
            int userin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the name of the Goal you would like to Create?");
            string gtitle = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string gdesc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int gpoints = Convert.ToInt32(Console.ReadLine());

            if (userin == 1)
            {
                SimpleGoal simple01 = new SimpleGoal(gtitle, gdesc, gpoints, userin);
                goals.Add(simple01);
            }
            if (userin == 2)
            {
                EternalGoal eternal01 = new EternalGoal(gtitle, gdesc, gpoints, userin);
                goals.Add(eternal01);
            }
            if (userin == 3)
            {
                Console.WriteLine("How many times does this goal need to be accomplished to get a bonus?");
                int cap = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the bonus for completing it that many times?");
                int bonus = Convert.ToInt32(Console.ReadLine());
                ChecklistGoal checklist01 = new ChecklistGoal(gtitle, gdesc, gpoints, userin, bonus, cap);
                goals.Add(checklist01);
            }

        }

        void Listgoals()
        {
            int listcount = 1;
            foreach (GoalBase goal in goals)
            {
                Console.Write($"{listcount} ");
                goal.Display();
                listcount++;
            }
        }    
        void RecordGoals()
        {
            int listcount = 1;
            Console.WriteLine("The goals are:");
            foreach (GoalBase goal in goals)
            {
                Console.Write($"{listcount} ");
                goal.Display();
                listcount++;
            }
            Console.WriteLine("Which goal did you accomplish?");
            int gnum = Convert.ToInt32(Console.ReadLine());
            int goalnum = gnum -1;
            goals[goalnum].Award();
        }
        void LoadGoals()
        {

            Console.WriteLine("What is the filename for the goal file?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            bool firstline = true;

            foreach (string line in lines)
            {
                if (firstline)
                {
                    GoalBase.Setcolectivescore(int.Parse(line));
                    firstline = false;
                    continue;
                } 
                string[] partsI = line.Split("|");
                if (int.Parse(partsI[0]) == 1)
                {
                    goals.Add(SimpleGoal.LoadFromStringRepresentation(line));
                }
                if (int.Parse(partsI[0]) == 2)
                {
                    goals.Add(EternalGoal.LoadFromStringRepresentation(line));
                }
                if (int.Parse(partsI[0]) == 3)
                {
                    goals.Add(ChecklistGoal.LoadFromStringRepresentation(line));
                }

                
            }
        }
            
        
    }
}

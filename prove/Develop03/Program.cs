using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        bool game_active = true;
        Scripture scripture01 = new Scripture();
        while (game_active == true)
        {
            Console.Clear();
           
            scripture01.Display();
            Console.WriteLine(" ");
            Console.WriteLine("Please enter to continue or type 'quit' to finsh:");
            string user_input = Console.ReadLine();
            if (user_input.ToLower() != "quit")
            {
                number = scripture01.randomchange();
                if (number == 0)
                {
                    game_active = false;
                }
            }else{break;}
            
        }


    }
    

}

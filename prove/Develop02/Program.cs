using System;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        bool game_active = true;
        Console.WriteLine("Welcome to Journal");
        List<Prompts> entries = new List<Prompts>();
        while (game_active == true)
        {
            Console.WriteLine("What would you like to do?: ");
            Console.WriteLine("1. Write in Journal");
            Console.WriteLine("2. Display current entries");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            int user_input = Convert.ToInt32(Console.ReadLine());

            if (user_input == 1)
            {
                Prompts prompt01 = new Prompts();
                prompt01.Pick_and_ask_q();
                entries.Add(prompt01);
            }else if (user_input == 2)
            {
                foreach (Prompts entry in entries)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{entry._datenow} {entry._pickedq} {entry._J_entry}");
                } 
            }else if (user_input == 3)
            {
                Saving load01 = new Saving();
                Console.WriteLine("What is the file name?");
                load01._filename = Console.ReadLine();
                entries = load01.FromTxt();
            }else if (user_input == 4)
            {
                Saving save01 = new Saving();
                Console.WriteLine("What is the Filename:");
                save01._filename = Console.ReadLine();
                save01.ToTxt(entries);
            }else if (user_input == 5)
            {
                break;
            }
            
            
            else{}
            
        }
        

    }
    
}


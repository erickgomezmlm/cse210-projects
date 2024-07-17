using System;

class Program
{
    static void Main(string[] args)
    {
        bool gameactive = true;
        while(gameactive)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userinput = Console.ReadLine();

            if(userinput == "1")
            {
                BreathingActivity breathing01 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking through your breathing in and out slowley. clear your mind and focus on your breathing.");
                breathing01.InteractiveBreathingActivity();
            }
            else if(userinput == "2")
            {
                ReflectingActivity reflect01 = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect01.InteractiveReflectiveActivity();
            }
            else if(userinput == "3")
            {
                ListingActivity listing01 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing01.InteractiveListingActivity();
            }
            else if(userinput == "4")
            {
                gameactive = false;
            }else{Console.WriteLine("Please enter a valid input...");}
        }
    }
}

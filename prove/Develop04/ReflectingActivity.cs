class ReflectingActivity : Activity
{
	public ReflectingActivity(string title, string descript) : base(title, descript)
	{
		_title = title;
		_descript = descript;
	}

	public void InteractiveReflectiveActivity()
	{
		string[] prompts = {
			"--- think of a time you did something really difficult ---",
			"--- Think of a moment you enjoyed this week ---", 
			"--- Think of fond memory you have ---"
			};
		string[] questions = {
			"How did you feel when it was complete", 
			"What is your favorite thing about this experience", 
			"What is something you learned from this experience"
			};
		prologue();
		
		Console.WriteLine("Consider the following prompt:\n");
		Random random = new  Random();
		int ranindex = random.Next(prompts.Length);
		string randomPrompt = prompts[ranindex];
		Console.WriteLine($"{randomPrompt}\n");
		Console.WriteLine("When you have something in mind, press enter to continue");
		//string none = Console.ReadLine();
		Console.ReadLine();
		
		Console.WriteLine("Now ponder the following questions as they are related to this experience.\n");
		Console.Write("You may begin in: ");
		Timers.Countdown();
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(_duration);
		Console.Clear();

		
		while(DateTime.Now < endTime)
		{	
			Random random01 = new  Random();
			int ranindex01 = random.Next(questions.Length);
			string randomquestion = questions[ranindex01];
			Console.WriteLine(randomquestion);
			Timers.SpinnerWithPause(7);
		}
		epilogue();

	}
}

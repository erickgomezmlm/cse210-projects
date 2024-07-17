class ListingActivity : Activity
{
	public ListingActivity(string title, string descript) : base(title, descript)
	{
		_title = title;
		_descript = descript;
	}

	public void InteractiveListingActivity()
	{
		prologue();
		string[] prompts = {"When have you felt the Holy Ghost this month?", "Who are people that you appreciate?", "What are personal strengths of yours?"};
		Random random = new  Random();
		int ranindex = random.Next(prompts.Length);
		string randomPrompt = prompts[ranindex];
		Console.WriteLine("List as many responses as you can to the following prompt: ");
		Console.WriteLine($"{randomPrompt}\n");
		Console.WriteLine("You may begin in: ");
		Timers.Countdown();
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(_duration);

		int numberofEntries = 0;
		while(DateTime.Now < endTime)
		{
			Console.WriteLine(">");
			Console.ReadLine();
			numberofEntries++;

		}

		Console.WriteLine($"You have written {numberofEntries} Entires!\n");
		Console.WriteLine("Well done!");
		epilogue();
		
	}
}

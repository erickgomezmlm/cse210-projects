class BreathingActivity : Activity
{
	public BreathingActivity(string title, string descript) : base(title, descript)
	{
		_title = title;
		_descript = descript;
	}

	public void InteractiveBreathingActivity()
	{
		prologue();
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(_duration);
		while(DateTime.Now < endTime)
		{
			Console.WriteLine("");
			Console.Write("Breath in ... ");
			Timers.Countdown();
			Console.WriteLine("");
			Console.Write("Breath out... ");
			Timers.Countdown(7);
			Console.WriteLine("");
		}
		epilogue();
	}
}

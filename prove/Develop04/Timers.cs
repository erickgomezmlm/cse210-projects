static class Timers
{
	
	public static void Countdown(int secs = 5)
	{
		while(secs > 0)
		{
			Console.Write(secs);
			Thread.Sleep(1000);
			Console.Write("\b \b");
			secs--;
		}
	}

	public static void SpinnerWithPause(int seconds = 5)
	{
		List<string> _animationString = new List<string>();
		_animationString.Add("/");
		_animationString.Add("-");
		_animationString.Add("\\");
		_animationString.Add("|");
		_animationString.Add("/");
		_animationString.Add("-");
		_animationString.Add("\\");
		DateTime startTime = DateTime.Now;
		DateTime endTime = startTime.AddSeconds(seconds);
		int i = 0;
		while(DateTime.Now < endTime)
		{
			string spinnie  = _animationString[i];
			Console.Write(spinnie);
			Thread.Sleep(1000);
			Console.Write("\b \b");
			i++;

			if(i >= _animationString.Count)
			{i = 0;}
		}
		Console.WriteLine("");
	}
	
}

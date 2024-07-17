class Activity
{
	protected string _title;
	protected string _descript;
	protected int _duration;

	public Activity(string title, string descript)
	{
		_title = title;
		_descript = descript;
	}


	public int getduration()
		{
			return _duration;
		}
	
	protected void prologue()
	{
		Console.WriteLine($"Welcome to the {_title}\n");
		Console.WriteLine(_descript);
		Console.WriteLine("How long in seconds do you want this session to be? ");
		int dura = int.Parse(Console.ReadLine());
		_duration = dura;
		Console.Clear();
		Console.Write("Get ready... ");
		Timers.SpinnerWithPause();

	}
	protected void epilogue()
	{
		Console.WriteLine($"You have completed {_duration} seconds of the {_title}");
		Timers.SpinnerWithPause();
	}
	
}   

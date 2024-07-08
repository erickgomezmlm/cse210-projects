class Assignment
{
	protected string _studentname;
	protected String _topic;

	public Assignment(string studentname, string topic)
	{
		_studentname = studentname;
		_topic = topic;
	}
	public string getstudentname()
	{
		return _studentname;
	}

	
	public string gettopic()
	{
		return _topic;
	}

	
	public void GetSummery()
	{
		Console.WriteLine($"Student: {_studentname}, Topic {_topic}");
	}
}

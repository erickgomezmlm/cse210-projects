class WritingAssignment : Assignment
{
	private string _title;

	public WritingAssignment(string studentname, string topic, string title) : base(studentname, title)
	{
		_title = title;
	}

	public void GetWritingInformation()
	{
		string studentname = getstudentname();
		Console.WriteLine($"The title is {_title} by {studentname}");
	}
}

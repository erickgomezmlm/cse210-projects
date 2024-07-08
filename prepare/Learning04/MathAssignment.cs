class MathAssignment : Assignment
{
	private string _textbookSelction;
	private string _problems;

	public MathAssignment(string studentname, string topic, string textbookselection, string problems) : base(studentname, topic)
	{
		_textbookSelction = textbookselection;
		_problems = problems;
	}

	public void GetHomeworkList()
	{
		Console.WriteLine($"Tonights homework is from {_textbookSelction}, problems {_problems}");
	}
}

class Video
{
	private string _title;
	private string _author;
	private int _length;
	private List<Comments> _comments = new List<Comments>();

	public Video(string title, string author, int length, List<Comments> comments)
	{
		_title = title;
		_author = author;
		_length = length;
		_comments = comments;
	}

	
	public int GetCommentCount()
	{
		return _comments.Count();
	}

	public void DisplayVideoInfo()
	{
		Console.WriteLine($"Title {_title}, by {_author}, {_length} minutes long");
		Console.WriteLine($"Comments {_comments.Count()}");
		foreach (Comments coment in _comments)
		{
			Console.WriteLine($"User: {coment.GetAccount()}");
			Console.WriteLine($"Says: {coment.GetText()}");
		}

	}
	
}

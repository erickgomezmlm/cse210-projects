class Reference
{
	private string _book;
	private int _chapter;
	private int _firstverse;
	private int _lastverse;

	public Reference(string book, int chapter, int firstverse, int lastverse = 0)
	{
		_book = book;
		_chapter = chapter;
		_firstverse = firstverse;
		_lastverse = lastverse;
	}

	public void Display()
	{
		if (_lastverse == 0)
		{
			Console.WriteLine($"{_book} {_chapter}: {_firstverse}");
		}

		else 
		{
			Console.WriteLine($"{_book} {_chapter}: {_firstverse}-{_lastverse}");
		}
	}
}

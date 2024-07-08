class Word
{
	private string _text;
	private bool _revealed;

	public string GetText()
	{
		return _text;
	}

	public void SetText(string text)
	{
		_text = text;
	}

	public bool IsRevealed()
	{
		return _revealed;
	}

	public void Hide()
	{
		_revealed = false;
	}

	public void Reveal()
	{
		_revealed = true;
	}	
	
	public void DisplayNorm()
	{
		Console.Write($"{_text} ");	
	}

	public void DisplayUnder()
	{
		string underword = new string('_', _text.Length);
		Console.Write($"{underword} ");
	}
}

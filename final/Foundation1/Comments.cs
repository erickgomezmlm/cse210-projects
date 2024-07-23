class Comments
{
	private string _account;
	private string _text;

	public Comments(string acount, string text)
	{
		_account = acount;
		_text = text;
	}

	public string GetAccount()
	{
		return _account;
	}

	public string GetText()
	{
		return _text;
	}
}

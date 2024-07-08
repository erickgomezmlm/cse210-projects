class Scripture
{
	private Reference _reference = new Reference("1 Nephi", 17, 50);
	private string _scripture = "And I said unto them: If God had commanded me to do all things I could do them. If he should command me that I should say unto this water, be thou earth, it should be earth; and if I should say it, it should be done.";
	private List<Word> _scripturewrdlst = new List<Word>();

	public Scripture()
	{
		string[] script = _scripture.Split(' ');
		foreach(string thing in script)
		{
			Word word01 = new Word();		
			word01.SetText(thing);
			word01.Reveal();
			_scripturewrdlst.Add(word01);
		}
		
	}

	public int randomchange()
	{
		
		List<Word> truewords = _scripturewrdlst.Where(o => o.IsRevealed()).ToList();

        if (truewords.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(truewords.Count);
            Word randomwordin = truewords[randomIndex];
            randomwordin.Hide();
		}
		return truewords.Count;

	}

	

	
	public void Display()
	{
		_reference.Display();	
		foreach(Word word in _scripturewrdlst)
		{
			if (word.IsRevealed())
			{
				word.DisplayNorm();				
			}
				
			else
			{
				word.DisplayUnder();
			}
		} 
		
		
			
	}
}

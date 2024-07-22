class ChecklistGoal : GoalBase
{
	private bool _iscomplete;
	private int _completionBonus;
	private int _accomplishcap;
	private int _currentAcomplished;

	public ChecklistGoal(string title, string desc, int score, int identifeir, int completionbonus, int accomplishedcap, bool iscomplete = false, int currentaccomplished = 0) : base(title, desc, score, identifeir)
		{
			_completionBonus = completionbonus;
			_accomplishcap = accomplishedcap;
			_iscomplete = iscomplete;
			_currentAcomplished = currentaccomplished;
		}
    public override void Award()
        {
            if (_currentAcomplished == _accomplishcap)
			{
				Console.WriteLine("You've already completed this goal...");
			}
			else if(_currentAcomplished == _accomplishcap - 1)
			{
				Console.WriteLine($"Congratulations!!! You've completed your goal {_accomplishcap}/{_accomplishcap} times!!!");
				Console.WriteLine($"You've earned {_score + _completionBonus} points!!!");
				_colectiveScore = _colectiveScore + _score + _completionBonus;
				_currentAcomplished++;
				_iscomplete = true;
			}
			else
			{
				Console.WriteLine($"Congratulations! You completed a step in your goal. You made {_score} points");
				_currentAcomplished++;
				_colectiveScore = _colectiveScore + _score;
			}
        }
    public override void Display()
        {
			if (_iscomplete)
            {
				Console.WriteLine($"[X] {_title} ({_desc}) -- Currently completed {_currentAcomplished}/{_accomplishcap}");
			}else{Console.WriteLine($"[ ] {_title} ({_desc}) -- Currently completed {_currentAcomplished}/{_accomplishcap}");}
        }
	public override string GetStringRepresentation()
	{
		return $"{_identifier}|{_title}|{_desc}|{_score}|{_completionBonus}|{_accomplishcap}|{_iscomplete}|{_currentAcomplished}";
	}
	public static ChecklistGoal LoadFromStringRepresentation(string str)
	{
		var parts = str.Split('|');
		return new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[0]),int.Parse(parts[4]), int.Parse(parts[5]), bool.Parse(parts[6]), int.Parse(parts[7]));
	}
}

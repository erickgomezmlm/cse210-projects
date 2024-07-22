using System.IO;
class SimpleGoal : GoalBase
{
	private bool _iscomplete;

	public SimpleGoal(string title, string desc, int score, int identifier, bool iscomplete = false) : base(title, desc, score, identifier)
		{
			_iscomplete = iscomplete;
		}
    public override void Award()
        {
            if (_iscomplete == false)
			{
				_colectiveScore = _colectiveScore + _score;
				Console.WriteLine($"Congratulations! You completed your goal. You made {_score} points");
				_iscomplete = true;
			}
			else
			{
				Console.WriteLine($"You've already Completed this goal...");
			}
        }
    public override void Display()
        {
			if (_iscomplete)
			{
				Console.WriteLine($"[X] {_title} ({_desc})");
			}
			else{Console.WriteLine($"[ ] {_title} ({_desc})");}
        }
	
	public override string GetStringRepresentation()
	{
		return $"{_identifier}|{_title}|{_desc}|{_score}|{_iscomplete}";
	}
	public static SimpleGoal LoadFromStringRepresentation(string str)
	{
		var parts = str.Split('|');
		return new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[0]),bool.Parse(parts[4]));
	}

}

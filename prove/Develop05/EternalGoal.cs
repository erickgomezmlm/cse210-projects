class EternalGoal : GoalBase
{
	public EternalGoal(string title, string desc, int score, int identifier) : base(title, desc, score, identifier)
	{}

    public override void Display()
        {
        	Console.WriteLine($"[ ] {_title} ({_desc})");
        }
	public override string GetStringRepresentation()
	{
		return $"{_identifier}|{_title}|{_desc}|{_score}";
	}
	public static EternalGoal LoadFromStringRepresentation(string str)
	{
		var parts = str.Split('|');
		return new EternalGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[0]));
	}
}

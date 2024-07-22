abstract class GoalBase
{
	protected string _title;
	protected string _desc;
	protected int _score;
	protected int _identifier;
	protected static int _colectiveScore;

	public GoalBase(string title, string desc, int score, int identifier)
	{
		_title = title;
		_desc = desc;
		_score = score;
		_identifier = identifier;
	}
	public static int GetColectiveScore()
	{
		return _colectiveScore;
	}
	public static void Setcolectivescore(int cscore)
	{
		_colectiveScore = cscore;
	}
	public int GetIdentifier()
	{
		return _identifier;
	}
	public virtual void Award()
	{
		_colectiveScore = _colectiveScore + _score;
		Console.WriteLine($"Congratulations! You completed you goal. You made {_score} points");
	}
	public abstract void Display();

	public abstract string GetStringRepresentation();

}

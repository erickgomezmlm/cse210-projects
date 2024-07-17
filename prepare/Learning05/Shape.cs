abstract class Shape
{
	protected string _color;

	public Shape(String color)
	{
		_color = color;
	}

	public string Getcolor()
	{
		return _color;
	}
	public void SetColor(string color)
	{
		_color = color;
	}
	public abstract double CalcArea();
}

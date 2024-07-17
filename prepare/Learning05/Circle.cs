class Circle : Shape
{
	double _radius;

	public Circle(string color, double radius) : base(color)
	{
		_radius = radius;
	}

    public override double CalcArea()
        {
            return _radius * _radius * Math.PI;
        }
}

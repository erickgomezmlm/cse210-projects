abstract class Activity
{
	string _date;
	double _minutes;

	protected abstract double GetDistance();
	protected abstract double GetSpeed();
	protected abstract double GetPace();
	protected abstract string GetSummery();
	
}

class Customer
{
	private string _name;
	private Address _adress;

	public bool Isdomestic()
	{
		if (_adress.Isdomestic())
		{
			return true;
		}else{return false;}
	}
	public string GetName()
	{
		return _name;
	}
	public string GetAddress()
	{
		return _adress.GetAddresslabel();
	}
}

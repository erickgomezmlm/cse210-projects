class Address
{
	private string _streetAdress;
	private string _city;
	private string _stateorprovinence;
	private string _country;

	public bool Isdomestic()
	{
		if (_country.ToLower() == "usa")
		{
			return true;
		}else{return false;}
	}
	public string GetAddresslabel()
	{
		return $"{_streetAdress} {_city}, {_stateorprovinence}, {_country}";
	}
}

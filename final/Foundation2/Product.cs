class Product
{
	private string _name;
	private string _id;
	private int _pricePerUnit;
	private int _quantity;
	private int _totalCost;

	public Product(string name, string id, int quantity)
	{
		_name = name;
		_id = id;
		_quantity = quantity;
	}


	public int GetTotalCost()
	{
		return _totalCost = _quantity * _pricePerUnit;
	}
}

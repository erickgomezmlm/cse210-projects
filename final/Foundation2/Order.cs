class Order
{
	List<Product> _cart = new List<Product>();
	Customer _customer;
	public Order(Customer customer)
	{
		_customer = customer;
	}
	public Product AddItem()
	{
		Product product01 = new Product("tots", "q235da", 6) ;
		return product01;
	}
	public int GetTotalCost()
	{
		return 8;
	}
	public string GetPackagingLabel()
	{
		return " ";
	}
	public string GetShippingLLabel()
	{
		return "";
	}
	
}

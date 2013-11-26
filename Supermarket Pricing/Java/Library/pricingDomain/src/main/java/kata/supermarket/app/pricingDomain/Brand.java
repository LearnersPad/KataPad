package kata.supermarket.app.pricingDomain;


/*
 * Represents a classification category 
 * for the abstraction called as Product 
 */
public class Brand {
	
	private String _name;
	
	public Brand(String brandName){
		_name = brandName;
	}
	
	public String getBrandName()
	{
		return _name;
	}
	
}

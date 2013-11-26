package kata.supermarket.app.pricingDomain;

public class Product {
	
	private String 					_name;
	private ProductPriceDescription _productPriceDescription;
	private Category				_category;
	private Brand					_brand;
	
	public Product(String name, 
			ProductPriceDescription priceDesc, 
			Category prodCategory,
			Brand brand){
		
		_name = name;
		_productPriceDescription = priceDesc;
		_category = prodCategory;
		_brand	  = brand;
	}
	
	public String getName(){
		return _name;
	}
	
	public ProductPriceDescription getPriceDescription()
	{
		return _productPriceDescription;
	}
	
	public Category getProductCategory(){
		return _category;
	}
	
	public Brand getBrand(){
		return _brand;
	}
}

package kata.supermarket.app.pricingDomain;

public class Category {
	
	private int _categoryID;
	private String _categoryName;
	private Category _parentCategory;
	
	public Category(int categoryID, String name, Category parent){
		_categoryID = categoryID;
		_categoryName = name;
		_parentCategory = parent;
	}
	
	public int getCategoryID()
	{
		return _categoryID;
	}
	
	public String getCategoryName(){
		return _categoryName;
	}
	
	public Category getParentCategory(){
		return _parentCategory;
	}
}

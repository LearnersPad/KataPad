package kata.supermarket.app.pricingDomain;

import java.util.Date;
import java.text.DateFormat;
import java.text.SimpleDateFormat;

public class Customer {
	
	private String _firstName;
	private String _lastName;
	private Date   _customerSince;
	private static DateFormat dateFormat;
	
	static {
        dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
    }
	
	public Customer(String fName, String lName)
	{
		_firstName = fName;
		_lastName  = lName;
		_customerSince = new Date();
	}
	
	public String getName()
	{
		return String.format("%s, %s", _lastName,_firstName);
	}
	
	public String getCustomerSince()
	{
		return dateFormat.format(_customerSince);
	}
}

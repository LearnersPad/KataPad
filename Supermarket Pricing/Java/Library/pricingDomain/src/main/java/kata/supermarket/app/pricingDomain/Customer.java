package kata.supermarket.app.pricingDomain;

import java.util.Date;
import java.text.DateFormat;
import java.text.SimpleDateFormat;

public class Customer {
	
	private String _firstName;
	private String _lastName;
	private Date   _customerSince;
	private static DateFormat dateFormat;
	private static int customerCounter;
	private String _mobileNumber;
	private int    _customerId;
	private String _email;
	
	static {
        dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
        customerCounter = 1000;
    }
	
	public Customer(String fName, String lName, String email, String mobileNumber)
	{
		_firstName = fName;
		_lastName  = lName;
		_customerSince = new Date();
		customerCounter += 1;
		_customerId = customerCounter;
		_email = email;
		_mobileNumber = mobileNumber;
	}
	
	public int getCustomerID(){
		return _customerId;
	}
	
	public String getName()
	{
		return String.format("%s, %s", _lastName,_firstName);
	}
	
	public String getCustomerSince()
	{
		return dateFormat.format(_customerSince);
	}
	
	public String getCustomerEmail()
	{
		return _email;
	}
	
	public String getMobileNumber(){
		return _mobileNumber;
	}
}

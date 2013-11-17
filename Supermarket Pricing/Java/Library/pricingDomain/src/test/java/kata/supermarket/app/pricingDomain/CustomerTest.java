package kata.supermarket.app.pricingDomain;

import junit.framework.TestCase;

public class CustomerTest extends TestCase {

	private Customer _customer;
	
	public CustomerTest(){
		_customer = new Customer("fName", "lName","fName@domain.com", "2323123322" );
	}
	
	public void testCustomer() {
		assertNotNull(_customer);
	}

	
	public void testGetName() {
		assertEquals("lName, fName", _customer.getName());
	}

	public void testGetCustomerSince() {
		assertNotNull(_customer.getCustomerSince());
	}

	public void testGetCustomerEmail() {
		assertEquals("fName@domain.com", _customer.getCustomerEmail());
	}

	public void testGetMobileNumber() {
		assertEquals("2323123322", _customer.getMobileNumber());
	}

}

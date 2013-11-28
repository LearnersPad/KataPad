using System;
using System.Globalization;

namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Represents the Customer Entity in the Supermarket
    /// </summary>
    public class Customer
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int    _mobileNumber;
        private readonly string _emailAddress;
        private readonly int    _id;

        /// <summary>
        /// CTor
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="id"></param>
        /// <param name="emailAddrs"></param>
        public Customer(
            string fName, 
            string lName, 
            int mobileNumber, 
            int id, 
            string emailAddrs)
        {
            _firstName = fName;
            _lastName = lName;
            _id = id;
            _mobileNumber = mobileNumber;
            _emailAddress = emailAddrs;
        }

        /// <summary>
        /// Gets the Customer Name
        /// </summary>
        public string CustomerName
        {
            get { return String.Format("{1}, {0}", _lastName, _firstName); }
        }


        /// <summary>
        /// Gets the Email Address
        /// </summary>
        public string EmailAddress
        {
            get { return _emailAddress; }
        }

        /// <summary>
        /// Gets the Mobile Number
        /// </summary>
        public string MobileNumber
        {
            get
            {
                return String.Format("+91{0}", _mobileNumber);
            }
        }
        /// <summary>
        /// Gets the Customer Identification Number
        /// </summary>
        public string CustomerId
        {
            get { return _id.ToString(CultureInfo.InvariantCulture); }
        }

    }
}
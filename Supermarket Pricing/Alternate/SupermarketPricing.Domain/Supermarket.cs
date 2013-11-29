using System.Collections.Generic;

namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Abstracts the concept of a Supermarket store
    /// </summary>
    public class Supermarket
    {
        private readonly string _name;
        private readonly Stock _stock;
        private readonly List<Customer> _customers; 

        /// <summary>
        /// Ctor for the Supermarket class
        /// </summary>
        /// <param name="name"></param>
        public Supermarket(string name)
        {
            _name = name;
            _stock = new Stock();
            _customers = new List<Customer>();

        }

        /// <summary>
        /// Gets the Name of the Stock
        /// </summary>
        public string Name
        {
            get { return _name; }
        }


        /// <summary>
        /// Gets the Stocks withing the supermarket
        /// </summary>
        public Stock Stock
        {
            get { return _stock; }
        }

        public IEnumerable<Customer> Customers
        {
            get { return _customers; }
        }

        /// <summary>
        /// Register a Customer for the Supermarket
        /// </summary>
        public void RegisterCustomer(Customer customerInstance)
        {
            _customers.Add(customerInstance);
        }

    }
}